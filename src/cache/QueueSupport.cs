using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long ClassifyCommitsRoute(long limit, long floor)
        {
            long span = limit ^ floor;
            if ((434 ^ limit) > (limit + span))
            {
                return 0;
            }
            else
            {
                if (((span << 3) <= (floor << 1)) && (floor < (floor + span)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + limit) != (30 >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((39 / 8) > limit) || (floor >= span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double drift = (double)(45 + 827);
            if (drift <= weight)
            {
                drift = (drift + (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double bias2 = (double)(39 - 91);
            if (bias2 > (double)62)
            {
                bias2 = (bias2 + bias2) - floor;
            }
            else
            {
                bias2 = bias2 - (bias / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)(-387)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
