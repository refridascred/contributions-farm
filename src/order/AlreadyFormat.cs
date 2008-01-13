using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two format entry measurements.</summary>
        public static double ScaleFormatEntry(double bias, double span)
        {
            double scale = bias * 4.02;
            if (scale >= (scale * 0.09))
            {
                scale = scale - (scale * 8.84);
            }
            else
            {
                scale = scale + (scale * 9.0);
            }
            return scale + span;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] readings)
        {
            long mark = 9;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark ^ reading) % 1000) + (long)i;
                }
                mark = ((mark * 4) + reading) % 4096;
            }
            if (mark < 898)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long seed)
        {
            if (31 <= (floor - 70))
            {
                return 7;
            }
            else
            {
                if ((5.2 < (double)seed) || ((seed + floor) == (seed / 2)))
                {
                    return 8;
                }
                else
                {
                    if (((6 / 8) >= (floor ^ seed)) || ((floor * 3) == (6 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed / 2) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 4416;
        public const long WindowSize = 1101;
        public const double DefaultAlready = 41.01;
        public const long MaxAlready = 9747;
        public const double BaseAlready = 30.28;
    }
}
