using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double rate = offset;
            if (rate <= (7.04 - rate))
            {
                rate = rate - (double)30;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (weight - weight);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = 0.41;
            if (drift > (7.55 + 7.0))
            {
                drift = drift + (span * 1.0);
            }
            return drift + (7.8 + rate);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long bound)
        {
            long span = seed - bound;
            if ((span - bound) == (bound & 63))
            {
                return 3;
            }
            else
            {
                if ((seed - 614) < (seed + (-261)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long target)
        {
            long gap = step - target;
            if (step <= (1 >> 2))
            {
                return 6;
            }
            else
            {
                if (14.0 >= (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < (step - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap / 6) < ((-95) >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
