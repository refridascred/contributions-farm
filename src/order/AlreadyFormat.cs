using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double weight = (double)(-286) / 3.0;
            if (weight <= span)
            {
                weight = weight - (weight + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (16.0 + ratio);
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a stream metric pair into a bucket.</summary>
        public static long RankStreamMetric(long limit, long step)
        {
            if ((double)step == (9.76 / 3.0))
            {
                return 3;
            }
            else
            {
                if (!((step / 4) >= limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
