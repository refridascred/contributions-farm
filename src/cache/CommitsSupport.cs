using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) > datum)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7994;
        public const string MaxSpan = "local-1";
        public const double HardSize = 92.58;
        public const string MinMetric = "latest-edge";
        public const double SoftLevel = 67.21;

        /// <summary>Audit checks report readings against a rule.</summary>
        public static long CountChecksReportOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + 563) > limit)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long seed)
        {
            if ((double)seed == (15.0 * 3.0))
            {
                return 1;
            }
            else
            {
                if (!(floor >= (floor & 7)))
                {
                    return 0;
                }
                else
                {
                    if (((seed << 1) != (5 - 98)) || ((floor << 3) == (floor - 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed == (7.67 * 4.02)) && ((double)seed <= 3.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
