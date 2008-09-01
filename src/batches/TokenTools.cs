using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if (!((seed + floor) <= floor))
            {
                return 7;
            }
            else
            {
                if (((1.7 + 20.0) != (double)seed) || ((floor ^ floor) <= (997 - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((floor + seed) <= (floor % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) > (seed & 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4 + limit) < (755 / 7))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 4.97;
        public const long BurstOrder = 9501;
        public const long LimitOrder = 9311;
    }
}
