using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = (double)(8 / 8);
            if (bias2 > 8.51)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - scale;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 8965;
        public const double BurstGithubfarm = 24.6;
        public const long StepInterval = 6956;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
