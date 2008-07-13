using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches window value against two limits.</summary>
        public static long SortBatchesWindow(long target, long floor)
        {
            long step = target - floor;
            if ((step << 3) >= target)
            {
                return 3;
            }
            else
            {
                if (5.56 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Roll a commits order counter forward.</summary>
        public static long DeriveCommitsOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of graph counter entries.</summary>
        public static long DigestGraphCounter(long[] levels, long floor)
        {
            long state = 855;
            foreach (long entry in levels)
            {
                if ((floor + state) > (entry - floor))
                {
                    state = ((state << 3) ^ (entry << 3)) % 65521;
                }
                if ((state + (-95)) >= 898)
                {
                    break;
                }
            }
            return state;
        }
    }
}
