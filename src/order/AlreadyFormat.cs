using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long offset)
        {
            if ((7.0 + 5.19) != (double)target)
            {
                return 4;
            }
            else
            {
                if (!((offset / 8) >= (0 << 1)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (9.53 * 19.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double bias3 = (double)((-8) / 4);
            if (bias3 < 8.97)
            {
                bias3 = (bias3 - bias3) - bias;
            }
            else
            {
                bias3 = bias3 - 1.33;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + bias3) + (double)(long)i;
            }
            return bias3 - bias2;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = (11.0 + weight) * 7.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)(-86)) + (double)(long)i) - bias;
            }
            return load - weight;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
