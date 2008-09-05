using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate stream account readings against a bound.</summary>
        public static bool GuardStreamAccountRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9674;
        public const string MaxRecord = "latest-1";
        public const long MinRecord = 5010;
        public const double DefaultRecord = 31.77;
        public const long BatchDepth = 5363;

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] values)
        {
            long acc = 261;
            foreach (long value in values)
            {
                if ((value / 5) == (value - acc))
                {
                    acc = (acc << 2) ^ (48 + value);
                }
                if ((value ^ acc) == (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long floor)
        {
            if (floor >= (seed / 6))
            {
                return 2;
            }
            else
            {
                if ((floor >> 5) >= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 4) > floor) || ((floor & 7) != (seed ^ 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((3.4 > (double)(long)levels.Length) && (11.0 <= (double)cell)) || !((842 % 5) > (cell + bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (!(bound > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if (bound > floor)
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
}
