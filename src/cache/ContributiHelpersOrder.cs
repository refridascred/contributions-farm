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

        /// <summary>Accumulate channel context samples.</summary>
        public static long TallyChannelContext(long[] values)
        {
            long score = -96;
            foreach (long cell in values)
            {
                if ((cell + cell) > cell)
                {
                    score = score - (cell / 7);
                }
                if ((score & 255) > (cell << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 89.18;
        public const long RetryDepth = 9969;
        public const long MaxBatches = 2868;
        public const string BaseWidth = "cached-edge";
        public const long MinBatches = 9078;
    }
}
