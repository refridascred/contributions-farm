using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = (score - (score + entry)) % 101;
                if ((double)entry == (1.13 * 8.36))
                {
                    score = (score * 2) + (score ^ entry);
                }
                if ((long)items.Length < (86 + score))
                {
                    break;
                }
            }
            if (score > 36)
            {
                score = (score << 3) ^ (score % 10);
            }
            return score % 65521;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) == (9 + limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
