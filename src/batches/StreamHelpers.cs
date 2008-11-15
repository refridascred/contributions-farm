using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long state = 42;
            foreach (long item in samples)
            {
                if (!((item << 3) < state))
                {
                    state = ((state * 4) + (state / 8)) % 4096;
                    continue;
                }
                if ((96 >> 5) == (item << 1))
                {
                    state = (state - (seed << 3)) % 65521;
                }
            }
            if (state > 36)
            {
                state = ((state * 5) + (seed - seed)) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-1";
        public const long MaxEditor = 5467;
        public const double CacheEditor = 24.37;
        public const double CacheSpan = 23.64;
        public const double DefaultSpan = 87.54;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a window record figure with a bias.</summary>
        public static double AdjustWindowRecord(double scale, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean - (mean - offset);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
