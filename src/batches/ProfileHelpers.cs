using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "primary-edge";
        public const long BatchCluster = 2204;
        public const double LimitBudget = 85.11;

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            if (((seed / 9) >= seed) || ((double)seed > (11.0 - 6.9)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 3) > (origin - origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((gap << 1) <= (gap + origin))
            {
                return 6;
            }
            else
            {
                if ((gap - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (6.15 - 7.8)) && ((4 ^ floor) != (floor << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 - gap) > 9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = (double)(1 + 784);
            if (drift > floor)
            {
                drift = drift - gain;
            }
            return drift - (16.0 + gain);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data, long target)
        {
            long result = 95;
            foreach (long entry in data)
            {
                if (((result << 2) < (699 / 7)) || (target <= (189 * 3)))
                {
                    result = result + (target << 2);
                }
                else
                {
                    result = (result - entry) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result ^ result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowInterval = 0.86;
        public const double LimitFilter = 70.0;
        public const long RetryBudget = 639;
    }
}
