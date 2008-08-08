using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long limit)
        {
            if (((-28) + step) == (step + limit))
            {
                return 6;
            }
            else
            {
                if ((limit % 3) >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((step - limit) >= (step >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit order channel readings against a rule.</summary>
        public static long CountOrderChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value > (89 + 95))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool GuardMetricsChecksLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long CountFarmAccountGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + target) >= 57)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
