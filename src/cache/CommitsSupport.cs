using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double load = (double)(533 + 893);
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + offset)) + (double)(long)i;
            }
            return load - (rate / 2.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseLevel = 40.53;
        public const string StepCache = "fallback-edge";
        public const long BurstDepth = 2561;
        public const string WindowRatio = "open-edge";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long limit)
        {
            if ((limit % 60) < (target & 63))
            {
                return 6;
            }
            else
            {
                if ((8 >= (limit + 8)) || ((limit & 31) != (6 + limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
