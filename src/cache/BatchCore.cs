using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 8188;
        public const double BurstEditor = 52.13;
        public const double CacheEditor = 5.83;
        public const long StepEditor = 4723;
        public const long IdleEditor = 3110;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Active,
            Closed,
            New,
            Retry,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double span)
        {
            double ratio = span * 4.99;
            if (ratio > rate)
            {
                ratio = ratio + (double)0;
            }
            else
            {
                ratio = ratio + (span * 0.6);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double mean = (double)(1 - 645);
            if (mean > scale)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean + (double)22;
            }
            return mean + scale;
        }
    }
}
