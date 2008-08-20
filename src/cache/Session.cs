using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen >= step)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches <= 4.0))
                {
                    matches = ((matches + 2) ^ value) + offset;
                }
            }
            return matches;
        }
    }
}
