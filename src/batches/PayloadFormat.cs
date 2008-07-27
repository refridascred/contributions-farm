using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long TallyRecordCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (3.0 + 0.1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (1 > (target + 581))
                {
                    result = result - (118 + result);
                    result = (result << 3) ^ (result ^ (long)i);
                }
                else
                {
                    result = result - (result / 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (bias * 4.02))
            {
                bias = bias + (floor / 5.0);
            }
            return bias + gain;
        }
    }
}
