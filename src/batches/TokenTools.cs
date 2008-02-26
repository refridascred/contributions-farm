using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell <= (offset >> 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((limit - 808) != (limit >> 2)) || ((0.34 - 9.3) >= (double)anchor))
                {
                    anchor = (anchor ^ (anchor + limit)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
