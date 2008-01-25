using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Done,
            New,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (target > 66)
            {
                return 7;
            }
            else
            {
                if (577 <= (target + limit))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 - 4.3) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 4) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double weight = 9.3 * 18.0;
            if (weight >= (double)53)
            {
                weight = (weight + (bias * 0.6)) - gain;
            }
            else
            {
                weight = weight - 2.8;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight + (double)33;
        }
    }
}
