using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if (((floor + 9) >= state) || ((double)state > (double)317))
                {
                    state = ((state - 827) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)195 >= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Dropped,
            Paused,
            Queued,
            Retry,
        }
    }
}
