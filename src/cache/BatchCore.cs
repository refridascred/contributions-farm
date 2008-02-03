using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 245;
            foreach (long reading in series)
            {
                if (((seed - seed) > 76) || (1 >= (sum >> 4)))
                {
                    sum = (((sum << 2) ^ seed) % 97) + reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long floor)
        {
            if (!(1.69 < (double)floor))
            {
                return 4;
            }
            else
            {
                if ((8.15 + 2.82) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool CheckClusterMetricsRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Synced,
            Locked,
            Done,
            Paused,
        }
    }
}
