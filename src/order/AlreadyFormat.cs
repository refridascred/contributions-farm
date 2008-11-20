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

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long AuditSessionCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (868 < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleTimeout = 296;
        public const long WindowWidth = 7338;
        public const long CacheChecks = 7402;
        public const double RetrySpan = 65.03;
    }
}
