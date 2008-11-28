using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 3) <= hits)
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 6401;
        public const string BurstBuffer = "fallback";
        public const long WindowRatio = 4327;

        /// <summary>Derive the next counter filter value from a seed.</summary>
        public static long DeriveCounterFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + (anchor << 2);
                if (((long)i <= step) || ((5.53 + 6.8) >= (double)anchor))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
