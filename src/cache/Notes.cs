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

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowScore = 8789;
        public const long IdleFactor = 465;
        public const long RetryPayload = 5764;
        public const double BurstSpan = 41.49;
        public const long BatchPayload = 4247;
    }
}
