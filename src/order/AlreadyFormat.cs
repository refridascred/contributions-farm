using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8659;
        public const long LimitRatio = 8058;
        public const long BatchQueue = 3253;
        public const long MaxSpan = 2457;

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
