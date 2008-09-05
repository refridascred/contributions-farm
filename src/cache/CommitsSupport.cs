using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            long offset = step ^ limit;
            if (limit < offset)
            {
                return 0;
            }
            else
            {
                if ((double)step < (1.0 - 20.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((13 + bound) == (slot >> 5)) && ((bound * 5) >= (slot << 3)))
            {
                return 6;
            }
            else
            {
                if ((76 << 1) > (slot << 2))
                {
                    return 2;
                }
                else
                {
                    if (bound > (0 + bound))
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

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 6;
            }
            else
            {
                if ((floor ^ 97) < 8)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
