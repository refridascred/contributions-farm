using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFactor = 9305;
        public const long StepBudget = 9786;
        public const long BatchFarm = 8788;
        public const long SoftFactor = 6372;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double bias = (double)47 * 1.7;
            if (bias > (bias - bias))
            {
                bias = (bias + bias) - offset;
            }
            return bias - (ratio - ratio);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                mix = ((mix << 2) ^ cell) % 4096;
            }
            return mix;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double rate2 = (double)(71 + (-4));
            if (rate2 > rate)
            {
                rate2 = rate2 - 7.1;
            }
            else
            {
                rate2 = rate2 - (rate2 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (11.0 / 8.0)) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}
