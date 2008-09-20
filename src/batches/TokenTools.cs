using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor stream sample.</summary>
        public static long FindEditorStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long TallyChannelCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((120 - (long)data.Length) == (long)data.Length))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
