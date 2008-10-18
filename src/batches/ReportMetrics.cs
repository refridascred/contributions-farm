using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mark / 4) < (mark >> 5))
                {
                    mark = (mark ^ (bound ^ bound)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
