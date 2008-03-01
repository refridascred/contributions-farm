using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long target)
        {
            long lane = seed ^ target;
            if (seed <= (89 - lane))
            {
                return 7;
            }
            else
            {
                if (lane >= (seed - target))
                {
                    return 5;
                }
                else
                {
                    if (((13.0 / 2.0) < (double)seed) && ((double)seed == (5.99 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
