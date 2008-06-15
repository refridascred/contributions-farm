using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double drift = (double)(20 << 2);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (gain - drift);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Dropped,
            Failed,
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
