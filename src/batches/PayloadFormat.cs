using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats channel reading.</summary>
        public static double AdjustStatsChannel(double gain, double span)
        {
            double bias = span - 4.0;
            if (bias <= (span * 2.0))
            {
                bias = bias - (gain / 2.0);
            }
            else
            {
                bias = bias + span;
            }
            return bias + gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6156;
        public const double RetryProfile = 90.17;
        public const long SoftSpan = 5724;
        public const long MinLevel = 292;
        public const double CacheScore = 80.45;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long offset)
        {
            if (seed > (seed ^ seed))
            {
                return 8;
            }
            else
            {
                if (((offset / 4) <= offset) && ((double)seed >= (9.6 * 1.9)))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + offset) <= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
