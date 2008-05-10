using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4963;
        public const double BatchAlready = 13.84;
        public const long IdleAlready = 3663;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count >= (9.0 / 5.0)))
                {
                    count = ((count + 3) ^ datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
