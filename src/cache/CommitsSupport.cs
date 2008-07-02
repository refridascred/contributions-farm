using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double bias = floor;
            if (bias < (double)73)
            {
                bias = (bias - floor) - rate;
            }
            else
            {
                bias = bias - (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (bias * 7.73);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                result = (result << 3) ^ (72 + entry);
                if (2 <= (result << 1))
                {
                    result = (result - (entry - entry)) % 1000;
                }
                else
                {
                    result = result ^ 73;
                }
            }
            if (result > 8)
            {
                result = result ^ (result >> 5);
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6533;
        public const long DefaultFactor = 8243;
        public const string WindowQueue = "fallback-1";
    }
}
