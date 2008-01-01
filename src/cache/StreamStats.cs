using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter stream input into a small class.</summary>
        public static long ClassifyCounterStream(long target, long offset)
        {
            long gap = target ^ offset;
            if ((gap >> 2) < (gap << 2))
            {
                return 1;
            }
            else
            {
                if ((double)gap != (0.7 * 10.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)9 >= (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 2653;
        public const long BurstSize = 5955;
        public const double RetryDepth = 51.59;

        /// <summary>Validate counter stream readings against a bound.</summary>
        public static bool ValidateCounterStreamLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long TallyFarmFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) >= (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
