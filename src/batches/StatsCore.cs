using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "primary";
        public const double MaxSize = 22.86;
        public const double DefaultContext = 0.64;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long floor)
        {
            if ((offset + floor) <= (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if ((20.0 > (double)offset) && (floor <= offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series, long step)
        {
            long mix = -62;
            foreach (long item in series)
            {
                if (mix >= 603)
                {
                    mix = ((mix - step) % 101) + item;
                }
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
