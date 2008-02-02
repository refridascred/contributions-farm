using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2287;
        public const string StepScore = "fallback";
        public const string BurstTimeout = "fallback-v2";
        public const long SoftFactor = 1688;
        public const long CacheEntry = 3464;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (11.0 + 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter editor figure with a bias.</summary>
        public static double BlendCounterEditor(double bias, double offset)
        {
            double bias2 = offset / 7.0;
            if (bias2 <= (double)239)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias / 6.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9600;
        public const long BurstBudget = 9687;
        public const double DefaultCounter = 52.62;
        public const string DefaultSize = "fallback-edge";
    }
}
