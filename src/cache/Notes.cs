using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long offset)
        {
            long score = 80;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((((score * 4) + (998 >> 4)) % 4096) ^ (long)i) - offset;
                }
                score = score ^ (score + cell);
            }
            if (score > 80)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) == (value << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up report checks samples.</summary>
        public static long OverlapReportChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
