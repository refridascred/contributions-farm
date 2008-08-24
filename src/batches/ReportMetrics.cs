using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long limit)
        {
            if (!((93 / 7) <= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin >= (limit - 3)) && ((9 * 4) < (origin + 849)))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 5) > (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 5766;
        public const long BurstBatches = 7717;
        public const string BurstFactor = "local-v2";
        public const long MaxBatches = 8858;
    }
}
