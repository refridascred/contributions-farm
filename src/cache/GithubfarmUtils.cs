using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6.0 * 3.97) <= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long step)
        {
            long score = 81;
            foreach (long item in readings)
            {
                score = (((score << 3) ^ (step + score)) % 1000) - item;
                score = (score ^ 195) % 97;
                if (!((4.8 - 7.0) <= (double)score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
