using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of schema command readings.</summary>
        public static long MatchSchemaCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(count <= value) && (((value * 4) >= (origin * 5)) && ((5.1 / 2.0) <= (double)origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
