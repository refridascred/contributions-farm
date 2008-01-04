using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long CountRouteStreamOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((171 + count) > ((-512) << 3))
                {
                    count = ((count + 3) + sample) + step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
