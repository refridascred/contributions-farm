using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback-edge";
        public const double BurstCount = 29.43;
        public const long LimitSize = 6513;
        public const string SoftCommand = "local-1";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long target, long floor)
        {
            if ((floor >= (944 + floor)) && (target < (floor % 97)))
            {
                return 1;
            }
            else
            {
                if (!((double)target == (1.0 - 1.0)))
                {
                    return 7;
                }
                else
                {
                    if ((floor + target) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor >= ((-4) - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long CombineNotesCache(long[] samples, long origin)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                if ((reading & 127) <= 130)
                {
                    state = (state + reading) - origin;
                }
            }
            if (state > 1)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Blend two profile editor measurements.</summary>
        public static double BlendProfileEditor(double weight, double floor)
        {
            double weight2 = 17.0;
            if (weight2 < floor)
            {
                weight2 = weight2 + (weight2 + floor);
            }
            else
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - weight;
        }
    }
}
