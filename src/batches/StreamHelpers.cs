using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed / 7) > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)787)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (7 & 1)) && ((seed & 63) < (seed + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) >= (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double ratio = (bias / 5.0) * 5.89;
            if (ratio < (double)(-2))
            {
                ratio = ratio + (double)2;
            }
            return ratio + scale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long limit)
        {
            long state = 23;
            foreach (long item in readings)
            {
                if ((4 + limit) >= (state / 3))
                {
                    state = (((state * 5) + (state + limit)) % 255) - item;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 8030;
        public const string RetryFilter = "alpha-1";
        public const long StepFilter = 8100;
        public const double BatchInterval = 17.75;
        public const long LimitInterval = 6587;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
