using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long bound)
        {
            long mix = 57;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix << 3) ^ ((long)i ^ (long)i)) % 4096) + value;
                }
                mix = mix + (264 / 9);
                mix = (mix ^ bound) % 101;
            }
            return mix;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (slot > (seed + slot))
            {
                return 5;
            }
            else
            {
                if ((seed >> 2) <= (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((slot - bound) >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 7) <= (533 + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
