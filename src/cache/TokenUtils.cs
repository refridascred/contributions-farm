using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((9.0 / 3.0) == (double)hits) || !((entry * 4) <= 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
