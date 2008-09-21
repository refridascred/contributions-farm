using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((double)step2 >= (7.3 + 0.71))
            {
                return 8;
            }
            else
            {
                if ((step >> 2) < (step2 - step))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if (((double)seed != (2.0 * 12.0)) && ((seed + seed) > (seed2 & 7)))
            {
                return 7;
            }
            else
            {
                if (((seed2 + 782) <= 35) || ((seed2 + seed2) < (seed2 ^ 5)))
                {
                    return 3;
                }
                else
                {
                    if ((1.7 / 3.0) >= (double)seed2)
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < (item * 5)) || ((((-1) + (-975)) <= item) || ((tally + tally) >= (660 + 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading == (4.0 * 5.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryInterval = 2705;
        public const double HardBuffer = 40.6;
        public const long BaseBuffer = 9250;
        public const long MinBuffer = 333;
        public const double BaseFactor = 13.93;
    }
}
