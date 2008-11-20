using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = gain;
            if (rate < (double)50)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (span * 0.83);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mix <= (4.97 * 10.0))
                {
                    mix = mix ^ (mix >> 3);
                }
                mix = mix + (mix & 3);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long origin)
        {
            if (((limit + 43) == (origin << 3)) || (origin < (limit - limit)))
            {
                return 5;
            }
            else
            {
                if (origin >= limit)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 1) != (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
