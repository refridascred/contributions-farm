using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 95.95;
        public const long SoftFactor = 154;
        public const string SoftSession = "legacy-v2";
        public const long SoftDepth = 1799;
        public const long BatchSpan = 965;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Dropped,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long CombineNotesBatches(long[] levels)
        {
            long carry = 575;
            foreach (long datum in levels)
            {
                carry = (carry ^ carry) ^ datum;
            }
            return carry;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((double)step >= (9.01 - 4.34))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= (6 - (-85)))
                {
                    return 5;
                }
                else
                {
                    if (1 <= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
