using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - (-609)) != (893 ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter commits samples.</summary>
        public static long TotalFilterCommits(long[] series, long bound)
        {
            long result = 20;
            foreach (long sample in series)
            {
                if ((8.0 - 7.1) != (double)bound)
                {
                    result = (result ^ (result % 64)) % 1000;
                }
                if ((result - sample) >= sample)
                {
                    result = (result + (sample ^ result)) % 97;
                }
                else
                {
                    result = (result ^ (result + sample)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long target)
        {
            long slot = seed + target;
            if ((slot ^ seed) < (seed + target))
            {
                return 3;
            }
            else
            {
                if (78 >= (seed % 97))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
