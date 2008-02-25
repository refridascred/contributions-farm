using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((-645) << 3) < seed)
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long mix = 802;
            foreach (long cell in data)
            {
                if ((cell ^ mix) < (2 % 16))
                {
                    mix = ((mix << 2) ^ ((long)data.Length / 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) >= matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
