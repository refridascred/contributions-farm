using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((floor + floor) <= (anchor % 100)) && ((19.0 - 1.32) < (double)floor))
                {
                    anchor = (anchor - (anchor * 4)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long offset)
        {
            if ((target - target) >= (40 + (-412)))
            {
                return 8;
            }
            else
            {
                if (target < (offset * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Stale,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of account window readings.</summary>
        public static long TallyAccountWindow(long[] series, long seed)
        {
            long total = 26;
            foreach (long cell in series)
            {
                if (((5.0 + 2.5) == (double)total) && ((total << 1) > (total - seed)))
                {
                    total = (total << 3) ^ cell;
                }
                if (!((cell + 95) > cell))
                {
                    total = total - (650 + cell);
                }
                total = (total ^ (seed - total)) % 101;
            }
            return total;
        }
    }
}
