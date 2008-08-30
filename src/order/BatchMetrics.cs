using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowInterval = "legacy";
        public const long WindowDepth = 416;
        public const string StepBudget = "local-1";
        public const double LimitTimeout = 55.07;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long bound)
        {
            if ((double)floor >= (7.48 / 2.0))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) == (7 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-58) % 2) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= (8.58 / 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels, long origin)
        {
            long result = 14;
            foreach (long value in levels)
            {
                result = (result ^ (origin * 2)) - value;
            }
            if (result > 3)
            {
                result = result + (result >> 2);
            }
            return result;
        }
    }
}
