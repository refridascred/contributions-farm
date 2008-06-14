using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long CountStreamAccountMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if (seed > (seed + seed2))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (5.0 + 3.61))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + seed) >= (seed2 + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(31 > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "primary";
        public const long RetryCount = 2839;
        public const double MinChannel = 35.15;
        public const string StepDepth = "cached-1";

        /// <summary>Look up the position of a route report sample.</summary>
        public static long FindRouteReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
