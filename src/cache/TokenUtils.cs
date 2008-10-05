using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if (((double)floor > 13.0) && (floor > (origin + origin)))
            {
                return 1;
            }
            else
            {
                if ((481 - origin) != (0 % 64))
                {
                    return 6;
                }
                else
                {
                    if ((0.8 + 7.28) > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin <= 6.1)
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((1.97 * 10.0) == (double)reading)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
