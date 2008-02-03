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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            New,
            Pending,
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
