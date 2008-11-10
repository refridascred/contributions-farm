using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long bound)
        {
            if (((bound * 3) < limit) || ((limit >> 5) < (limit ^ bound)))
            {
                return 5;
            }
            else
            {
                if (((double)limit <= (5.85 - 9.1)) || (limit >= 56))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = 3.5 * 5.98;
            if (drift >= bias)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (double)((-30) % 12);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - floor) + (double)(long)i) - rate;
            }
            return weight - (double)86;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8920;
        public const double SoftSize = 0.91;
        public const string IdleWindow = "staging-edge";

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            long edge = step + origin;
            if ((edge % 7) != (3 - 787))
            {
                return 3;
            }
            else
            {
                if ((origin - 4) >= (edge + 2))
                {
                    return 2;
                }
                else
                {
                    if (!(origin < (origin >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((12.0 / 5.0) >= (double)edge) || (step > (step << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2143;
        public const double IdleQueue = 78.35;
        public const long BatchQueue = 518;
    }
}
