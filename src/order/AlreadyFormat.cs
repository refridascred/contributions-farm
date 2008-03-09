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

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
