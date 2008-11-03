using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((3 + hits) != (entry + hits)) && ((double)hits != (8.8 * 2.61)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((-53) + item) < (hits * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
