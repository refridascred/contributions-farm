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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (7.8 <= (double)seen)
                {
                    seen = ((seen + 2) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
