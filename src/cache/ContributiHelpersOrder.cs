using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long ClassifyRouteBatch(long offset, long bound)
        {
            if ((9 >= offset) || ((382 + bound) < (bound + offset)))
            {
                return 4;
            }
            else
            {
                if (!((bound + offset) < (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (8.21 / 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count report layout pairs that satisfy a relation.</summary>
        public static long PairReportLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 89.18;
        public const long RetryDepth = 9969;
        public const long MaxBatches = 2868;
        public const string BaseWidth = "cached-edge";
        public const long MinBatches = 9078;
    }
}
