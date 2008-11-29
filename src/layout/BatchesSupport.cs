using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next tools order value.</summary>
        public static double ScaleToolsOrder(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= ratio)
            {
                mean = mean - (ratio + mean);
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + (bias - ratio);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 59.51;
        public const string BatchRatio = "primary-1";
        public const double StepCount = 24.24;
        public const long SoftSpan = 1933;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Match up channel checks samples.</summary>
        public static long MatchChannelChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
