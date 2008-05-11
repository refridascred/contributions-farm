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

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples, long step)
        {
            long state = -64;
            foreach (long entry in samples)
            {
                state = ((state * 2) + step) ^ entry;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstSize = "local-1";
        public const double RetryLevel = 93.16;
        public const long RetryCluster = 8508;
        public const long LimitWidth = 9429;
    }
}
