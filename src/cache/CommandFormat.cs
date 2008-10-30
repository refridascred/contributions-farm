using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((9.6 * 20.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed < origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading == (2.1 * 3.0)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long TallyBatchCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 3) > count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
