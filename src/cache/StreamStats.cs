using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long sum = 993;
            foreach (long datum in levels)
            {
                if (((datum + datum) <= 61) && (0 < (sum + sum)))
                {
                    sum = ((sum + (sum - sum)) % 101) + target;
                }
            }
            if (sum > 910)
            {
                sum = (sum << 2) ^ (sum & 7);
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data, long seed)
        {
            long result = 478;
            foreach (long sample in data)
            {
                result = (((result << 2) ^ (sample - sample)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = (span - span) + (bias - bias);
            if (drift < bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift - (drift + 6.8);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
