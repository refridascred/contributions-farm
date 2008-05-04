using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long mark = 88;
            foreach (long sample in samples)
            {
                if ((2.0 - 8.6) >= (double)mark)
                {
                    mark = (((mark ^ (779 >> 4)) % 1000) - sample) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((10.0 + 9.02) != (double)origin))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
