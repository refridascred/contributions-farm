using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryFactor = 4367;
        public const double CacheMetric = 14.77;
        public const double SoftTimeout = 53.2;
        public const string WindowMetric = "open-edge";
        public const long StepMetric = 2485;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long target)
        {
            long next = origin - target;
            if ((next + next) < origin)
            {
                return 1;
            }
            else
            {
                if ((target * 5) == ((-6) - origin))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) == (origin + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - 4) >= (target << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((long)items.Length << 3) == (tally >> 4)) && (reading > (tally % 16)))
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
    }
}
