using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long origin)
        {
            if ((seed + 11) > seed)
            {
                return 1;
            }
            else
            {
                if (seed <= 3)
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 3) > (seed - origin)) && ((9.7 / 9.0) < (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed > (1.9 - 2.89))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool CheckChecksBatchRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 3601;
        public const long RetryCount = 8156;
        public const long MinLayout = 8038;
        public const string RetryBudget = "alpha-edge";
        public const double BurstLayout = 28.31;
    }
}
