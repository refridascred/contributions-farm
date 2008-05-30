using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = 20.0;
            return (scale + floor) + rate;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token command measurements.</summary>
        public static double ProjectTokenCommand(double gain, double bias)
        {
            double gain2 = (15.0 / 7.0) - bias;
            if (gain2 < gain2)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + bias;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value > 666)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
