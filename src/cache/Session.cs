using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long CountRecordGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
