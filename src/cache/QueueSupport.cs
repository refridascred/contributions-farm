using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a githubfarm filter reading by value.</summary>
        public static long LookupGithubfarmFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics token value against two limits.</summary>
        public static long GradeMetricsToken(long seed, long step)
        {
            if ((step + (-6)) >= (seed ^ step))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((801 <= (step + step)) || ((step / 2) >= (step - seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed ^ (-8)) >= step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "staging-edge";
        public const double IdleCount = 19.51;
        public const string BurstTimeout = "primary-1";
    }
}
