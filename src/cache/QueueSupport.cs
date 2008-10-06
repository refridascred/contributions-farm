using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items)
        {
            long total = 675;
            foreach (long entry in items)
            {
                if (entry >= (0 + total))
                {
                    total = (total + ((long)items.Length ^ total)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (total & 31);
                }
            }
            return total;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Pending,
            Done,
            Failed,
            New,
        }
    }
}
