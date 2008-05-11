using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            if (!(94 < (324 ^ limit)))
            {
                return 6;
            }
            else
            {
                if (!(limit > (limit * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((bound - 3) < limit) || ((double)bound != (2.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double load = floor - rate;
            if (load >= load)
            {
                load = load + (load - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)3) + (double)(long)i;
            }
            return load - (rate * 2.5);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Retry,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 56.9;
        public const string HardFactor = "staging-edge";
        public const string IdleGraph = "latest-v2";
        public const double HardBudget = 4.76;
    }
}
