using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 87.28;
        public const double CacheGraph = 5.71;
        public const long MinGraph = 7095;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((183 + reading) >= (tally / 2))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double bias = 9.96;
            if (bias <= 1.27)
            {
                bias = ((bias + (3.45 / 6.0)) - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + 1.82;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm stream entries that pass the check.</summary>
        public static long MeasureFarmStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((8 << 1) >= (floor & 1))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double gain = (double)(955 + 19);
            if (gain < (double)(-80))
            {
                gain = ((gain - 14.0) + ratio) + offset;
            }
            return gain + gain;
        }
    }
}
