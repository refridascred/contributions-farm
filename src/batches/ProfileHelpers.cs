using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel token readings against a rule.</summary>
        public static long MeasureChannelTokenGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((81 << 1) >= seen)
                {
                    seen = ((seen + 3) ^ reading) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Locate a stats stream reading by value.</summary>
        public static long SeekStatsStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double SmoothEditorProfile(double rate, double bias)
        {
            double scale = bias;
            return (scale - 5.9) + rate;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
