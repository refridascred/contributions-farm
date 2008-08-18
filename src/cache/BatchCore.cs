using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultWidth = 6205;
        public const long RetryAccount = 2386;
        public const long BatchSpan = 8593;
        public const double SoftBudget = 10.22;
        public const double BurstSize = 7.06;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long step)
        {
            if ((step % 60) < step)
            {
                return 1;
            }
            else
            {
                if ((bound + bound) != (bound - bound))
                {
                    return 7;
                }
                else
                {
                    if (((5.8 - 0.6) >= (double)bound) || (49 < (bound * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
