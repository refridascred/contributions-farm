using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long state = 738;
            foreach (long entry in readings)
            {
                if ((bound ^ entry) >= (entry * 5))
                {
                    state = (state * 2) + (bound * 3);
                }
            }
            if (state > 48)
            {
                state = (state - (state + 7)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long mix = 575;
            foreach (long cell in items)
            {
                if (!((double)275 <= (double)bound))
                {
                    mix = mix - mix;
                    mix = (mix << 3) ^ (mix * 3);
                }
                if ((cell ^ bound) > mix)
                {
                    mix = ((mix << 3) ^ (bound >> 5)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Pending,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long seed)
        {
            long mix = 3;
            foreach (long reading in items)
            {
                if ((reading <= mix) && ((1.0 * 0.27) >= (double)(long)items.Length))
                {
                    mix = ((mix + (396 >> 2)) % 65521) - seed;
                }
                else
                {
                    mix = (mix ^ ((-50) * 3)) % 255;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 3) ^ (mix + 0)) % 1000;
            }
            return mix % 97;
        }
    }
}
