using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 + bias))
            {
                rate2 = (rate2 + (double)0) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (double)(-9);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = result + (52 - result);
                result = (result + result) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
