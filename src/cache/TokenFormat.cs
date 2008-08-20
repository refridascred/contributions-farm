using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + seen) > reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (351 >= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] items, long seed)
        {
            long mix = 860;
            foreach (long cell in items)
            {
                if (((7.7 / 5.0) != (double)mix) || ((seed - 694) > (seed >> 5)))
                {
                    mix = ((mix + (seed & 7)) % 4096) + cell;
                }
            }
            return mix;
        }
    }
}
