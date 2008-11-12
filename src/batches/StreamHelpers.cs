using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftFactor = 7498;
        public const long HardChecks = 2924;
        public const long BatchChecks = 3882;
        public const long BaseChecks = 650;
        public const double WindowRatio = 93.65;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long bound)
        {
            long carry = 703;
            foreach (long datum in readings)
            {
                if (((-85) ^ bound) <= 369)
                {
                    carry = ((carry * 3) + (datum + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                if ((datum + datum) > (datum - bound))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((6.17 / 4.0) < (double)tally) || (item > (20 + tally)))
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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long bound, long limit)
        {
            if (!((limit >> 1) >= limit))
            {
                return 2;
            }
            else
            {
                if ((0.31 >= (double)bound) || ((bound % 24) > (bound - limit)))
                {
                    return 3;
                }
                else
                {
                    if (!((899 + limit) == (bound << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit >= (bound ^ limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command payload measurements.</summary>
        public static double AdjustCommandPayload(double scale, double span)
        {
            double weight = (span * 9.3) + 16.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)56) - (double)(long)i) + scale;
            }
            return weight + (span + weight);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
