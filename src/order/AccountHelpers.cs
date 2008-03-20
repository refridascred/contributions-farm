using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double mean = (double)(699 >> 5);
            if (mean < mean)
            {
                mean = mean + (weight + floor);
            }
            else
            {
                mean = mean - (5.58 * 6.62);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 6012;
        public const double BaseReport = 2.43;
        public const long SoftReport = 3385;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Active,
            Locked,
        }
    }
}
