using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double drift = 11.0;
            if (drift > scale)
            {
                drift = (drift + (double)1) + floor;
            }
            else
            {
                drift = drift + (scale / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (1.0 - drift)) + (double)(long)i;
            }
            return drift - (drift + scale);
        }

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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
