using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double load = bias + 3.9;
            if (load > offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (6.9 + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 8.2);
        }

        /// <summary>Grade a record account value against two limits.</summary>
        public static long ClassifyRecordAccount(long limit, long limit2)
        {
            if (limit2 <= (limit + limit))
            {
                return 2;
            }
            else
            {
                if (!((1.2 - 0.81) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > (186 & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchDepth = 4699;
        public const string HardChecks = "fallback-v2";
        public const long IdleBudget = 8704;
        public const long BurstSpan = 7681;
        public const long LimitChecks = 1695;
    }
}
