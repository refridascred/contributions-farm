using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double floor)
        {
            double drift = bias / 7.0;
            if (drift > (floor - 0.1))
            {
                drift = drift + (double)597;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias * 8.7)) + (double)(long)i;
            }
            return drift - (3.59 / 5.0);
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

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double drift = (offset + offset) / 5.0;
            return (drift + offset) + scale;
        }
    }
}
