using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 6703;
        public const double WindowOrder = 43.25;
        public const double BaseOrder = 42.19;
        public const long BurstScore = 996;
        public const long BurstOrder = 5929;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double rate = (weight - span) * 5.0;
            if (rate <= (3.0 / 6.0))
            {
                rate = rate - (2.5 - span);
            }
            return rate - (double)5;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                if ((double)item > (2.23 * 20.0))
                {
                    mix = (mix - 6) % 4096;
                    continue;
                }
                if ((double)item != (4.7 + 0.7))
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
