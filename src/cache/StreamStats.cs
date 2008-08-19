using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = result + (floor + floor);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = (double)(90 + 3);
            return (rate - (bias2 + rate)) + bias;
        }
    }
}
