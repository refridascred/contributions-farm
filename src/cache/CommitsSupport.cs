using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double load = bias;
            if (load > (load + load))
            {
                load = load - (offset * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)532;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 2) < 7)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long floor)
        {
            if ((double)seed >= (19.0 / 4.0))
            {
                return 0;
            }
            else
            {
                if (((seed ^ 9) < (78 + seed)) || ((floor % 97) <= (seed % 64)))
                {
                    return 7;
                }
                else
                {
                    if (((floor & 127) < (floor & 3)) || ((seed - seed) == (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((99 + floor) == (floor ^ seed)) || ((double)15 == (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "open-v2";
        public const long DefaultTimeout = 6302;
        public const string BurstFilter = "primary";
    }
}
