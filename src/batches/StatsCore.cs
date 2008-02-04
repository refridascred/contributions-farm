using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two checks account measurements.</summary>
        public static double SmoothChecksAccount(double rate, double span)
        {
            double bias = span - (7.8 / 8.0);
            if (bias < (span / 4.0))
            {
                bias = (bias + bias) - rate;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 8.0) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit + floor) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((limit + 87) != (limit & 127))
                {
                    return 2;
                }
                else
                {
                    if ((7 % 64) != (diff - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)4 > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long TallyRecordAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - tally) == (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)seed == (double)sample) || (((double)seen >= (6.2 * 16.0)) || ((seed << 3) >= (sample - seed))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long floor)
        {
            long edge = target - floor;
            if ((double)edge >= 10.0)
            {
                return 8;
            }
            else
            {
                if ((5.72 * 5.8) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!(9 <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
