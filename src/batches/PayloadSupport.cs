using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Classify a checks account pair into a bucket.</summary>
        public static long ClassifyChecksAccount(long seed, long target)
        {
            if (123 > (seed - seed))
            {
                return 3;
            }
            else
            {
                if ((seed > target) || (((-561) - seed) == (target << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - target) <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (seed >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (4 < bound)
                {
                    mix = (mix - bound) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
