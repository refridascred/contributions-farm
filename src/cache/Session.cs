using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mix = 60;
            foreach (long item in series)
            {
                mix = (mix * 4) + (item ^ origin);
                if ((mix * 4) >= (372 - origin))
                {
                    mix = (mix << 3) ^ (origin & 63);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio2 - span))
            {
                ratio2 = ratio2 + 6.1;
            }
            return ratio2 + (double)1;
        }

        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool CheckCacheReportRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
