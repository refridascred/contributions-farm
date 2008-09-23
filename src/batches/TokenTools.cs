using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((19.0 / 2.0) == (double)floor)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
