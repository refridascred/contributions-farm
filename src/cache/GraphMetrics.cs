using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double weight = offset;
            if (weight >= gain)
            {
                weight = weight + 10.0;
            }
            return weight - gain;
        }
    }
}
