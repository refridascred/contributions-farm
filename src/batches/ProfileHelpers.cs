using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double gain = offset;
            if (gain >= (double)22)
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain + (gain * 4.6);
            }
            return gain + gain;
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
