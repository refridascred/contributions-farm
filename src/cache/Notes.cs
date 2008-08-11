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

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long state = 75;
            foreach (long entry in readings)
            {
                if ((target ^ state) > target)
                {
                    state = (state ^ target) % 97;
                    break;
                }
                state = state - (target + entry);
                if ((state + 71) != (state - entry))
                {
                    state = (state - (entry - (-7))) % 101;
                }
            }
            if (state > 394)
            {
                state = (state ^ (target * 5)) % 65521;
            }
            return state;
        }

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
