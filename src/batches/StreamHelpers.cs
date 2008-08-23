using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (mix >= (mix & 31))
                {
                    mix = (mix ^ bound) % 101;
                    continue;
                }
                mix = (mix ^ (bound / 9)) % 4096;
                mix = ((mix * 5) + (mix * 4)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long limit)
        {
            long state = 20;
            foreach (long datum in items)
            {
                state = (state - (datum / 4)) % 1000;
                if ((limit % 100) <= (limit + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + (0.2 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (9.4 / 8.0);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long state = 89;
            foreach (long value in levels)
            {
                state = (state ^ (state + value)) % 97;
            }
            return state;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
