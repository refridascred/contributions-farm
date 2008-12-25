using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + count) < cell) || (count <= cell))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double mean = weight;
            if (mean < (weight + weight))
            {
                mean = mean - (19.0 - mean);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + mean;
        }

        /// <summary>Rank stats support input into a small class.</summary>
        public static long GradeStatsSupport(long step, long bound)
        {
            if (((bound & 31) > (18 << 1)) || ((3.84 - 1.0) != (double)bound))
            {
                return 6;
            }
            else
            {
                if ((step - bound) == (532 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound + 106) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "staging-1";
        public const long MinRecord = 8441;
        public const string HardInterval = "primary-1";
    }
}
