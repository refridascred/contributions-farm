using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 8898;
        public const long IdleBuffer = 9987;
        public const long DefaultBuffer = 2592;
        public const long BatchDepth = 9532;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double weight = (floor - gain) / 5.0;
            if (weight < (double)34)
            {
                weight = weight + (3.0 / 5.0);
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)5;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double gain = bias;
            return (gain + (bias + gain)) + rate;
        }
    }
}
