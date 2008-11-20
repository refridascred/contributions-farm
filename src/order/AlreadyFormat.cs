using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long SortCommandToken(long floor, long target)
        {
            long next = floor ^ target;
            if (((floor - 210) < (next >> 4)) || ((next ^ target) > (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (((next + floor) <= (504 - 2)) || (((-366) / 8) >= (target + 43)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + next) > (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster profile reading by value.</summary>
        public static long LookupClusterProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long state = 29;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state * 3) + sample) ^ (long)i) + seed;
                }
                if ((state + state) < (sample + 64))
                {
                    state = (state * 5) + (state >> 4);
                }
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleTimeout = 296;
        public const long WindowWidth = 7338;
        public const long CacheChecks = 7402;
        public const double RetrySpan = 65.03;
    }
}
