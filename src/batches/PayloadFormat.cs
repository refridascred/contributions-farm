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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
