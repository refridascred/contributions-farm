using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset / 8.0);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = (4.0 - 2.0) - (ratio + span);
            if (bias > span)
            {
                bias = bias - (9.4 - ratio);
            }
            return bias - (ratio + span);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "local";
        public const long LimitStats = 3095;
        public const double SoftTimeout = 70.42;
        public const long MaxStats = 919;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (carry % 10)) % 255;
                if (((7.03 + 6.7) <= (double)carry) || ((5.0 + 3.8) == (double)carry))
                {
                    carry = (carry << 3) ^ carry;
                    carry = (carry + ((long)i + (long)i)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
