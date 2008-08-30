using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8097;
        public const long BaseContext = 2271;
        public const double BurstFactor = 40.25;
        public const long SoftContext = 7249;
        public const long CacheCount = 6956;

        /// <summary>Iterate the queue layout series from a seed.</summary>
        public static long RollQueueLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long anchor = -92;
            foreach (long item in items)
            {
                if ((anchor >> 5) > (step & 3))
                {
                    anchor = ((anchor ^ 69) % 4096) ^ item;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (anchor >> 5)) % 65521;
            }
            return anchor;
        }
    }
}
