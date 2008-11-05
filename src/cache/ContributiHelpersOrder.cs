using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor + 17) < (-93))
            {
                return 3;
            }
            else
            {
                if (bound < floor2)
                {
                    return 1;
                }
                else
                {
                    if (floor < (floor2 / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + mix)) % 97;
                if (((357 % 10) <= mix) && (7.97 < (double)mix))
                {
                    mix = mix ^ (mix - datum);
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 7792;
        public const string IdleTimeout = "strict";
        public const double MaxContext = 47.37;
        public const long SoftContext = 1973;
        public const long CacheInterval = 2862;
    }
}
