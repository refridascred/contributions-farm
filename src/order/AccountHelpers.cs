using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double gain = (double)(75 / 2);
            return ((gain + 2.7) + ratio) + offset;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (bias + bias))
            {
                drift = (drift + (drift + drift)) + rate;
            }
            else
            {
                drift = drift + (double)458;
            }
            return drift + (drift * 3.4);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double ratio = span;
            if (ratio > (double)11)
            {
                ratio = (ratio - (double)806) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (10.0 - span);
        }
    }
}
