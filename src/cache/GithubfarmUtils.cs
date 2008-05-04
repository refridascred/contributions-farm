using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((4.71 - 1.0) > (double)seen) || ((cell / 5) >= (cell & 127))))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream payload pair into a bucket.</summary>
        public static long ClassifyStreamPayload(long floor, long limit)
        {
            if ((floor & 63) != (limit / 4))
            {
                return 4;
            }
            else
            {
                if (2.47 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) > (limit * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardScore = "strict";
        public const double IdleDepth = 90.23;
        public const double RetryCount = 95.48;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long anchor = 64;
            foreach (long item in samples)
            {
                if ((6 + anchor) != (item >> 4))
                {
                    anchor = anchor ^ (limit * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
