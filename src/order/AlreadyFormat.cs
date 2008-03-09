using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double drift = (double)(214 * 4);
            if (drift < drift)
            {
                drift = (drift - (bias + drift)) + rate;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias / 9.0)) + (double)(long)i;
            }
            return drift - (7.48 / 5.0);
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
