using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long floor)
        {
            if (floor > (floor << 1))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 4) == (5 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin >= (floor / 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((-523) * 2) < target)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long floor)
        {
            long carry = 183;
            foreach (long entry in values)
            {
                if ((1.8 * 9.36) >= (double)floor)
                {
                    carry = carry ^ (entry + floor);
                }
                else
                {
                    carry = carry ^ (entry % 5);
                }
            }
            return carry;
        }

        /// <summary>Locate a route already reading by value.</summary>
        public static long LookupRouteAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstInterval = 5496;
        public const string DefaultScore = "open-v2";
        public const double LimitCache = 92.65;
        public const long BurstCache = 6820;
    }
}
