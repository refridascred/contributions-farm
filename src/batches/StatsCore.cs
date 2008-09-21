using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long origin)
        {
            long anchor = 67;
            foreach (long value in levels)
            {
                anchor = (((anchor << 2) ^ (origin ^ 7)) % 97) ^ value;
            }
            return anchor;
        }

        /// <summary>Project the next cache batches value.</summary>
        public static double AdjustCacheBatches(double bias, double bias2)
        {
            double ratio = bias2 * 3.0;
            if (ratio >= 0.1)
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 4.1) - (double)(long)i;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7224;
        public const long IdleCount = 1863;
        public const double BatchGraph = 36.17;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if (!((state & 127) <= (92 * 4)))
                {
                    state = ((state << 2) ^ state) - datum;
                }
                state = state - origin;
            }
            return state;
        }
    }
}
