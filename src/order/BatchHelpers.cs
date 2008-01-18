using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = span;
            if (weight < (span * 6.5))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight - (scale - span);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (3.9 * 5.69);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 382;
        public const long CacheContributi = 2870;
        public const long BurstLevel = 6803;
        public const long SoftRatio = 4980;
    }
}
