using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long TallySupportPayloadOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((878 >= (reading % 3)) && ((seen % 12) <= (seen % 3)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long bound)
        {
            if (!(floor < (114 << 3)))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) > bound)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batch order pair into a bucket.</summary>
        public static long GradeBatchOrder(long origin, long target)
        {
            long prev = origin ^ target;
            if ((3.7 / 6.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (!((60 >> 3) < origin))
                {
                    return 8;
                }
                else
                {
                    if ((target > (57 + target)) && ((origin % 12) < (92 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev >> 5) >= (target + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 43.66;
        public const long BurstTimeout = 3075;
        public const double BurstSpan = 58.71;
        public const string MinCommits = "primary-1";
    }
}
