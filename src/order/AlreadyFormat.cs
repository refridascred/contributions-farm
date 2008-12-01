using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (9.1 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long total = 642;
            foreach (long reading in readings)
            {
                if ((reading % 8) > total)
                {
                    total = (total + (reading ^ total)) % 4096;
                }
                if (((long)readings.Length & 63) >= (total / 8))
                {
                    break;
                }
            }
            if (total > 809)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
            }
            return total % 1000;
        }
    }
}
