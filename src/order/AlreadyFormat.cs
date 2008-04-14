using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7934;
        public const long StepCount = 7703;
        public const double LimitChannel = 41.89;
        public const long CacheChannel = 3284;
        public const long IdleInterval = 9958;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((9.0 + 9.25) >= (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long step2)
        {
            long bound = step ^ step2;
            if ((2 <= (step2 / 8)) || ((step ^ bound) < (step2 ^ step)))
            {
                return 0;
            }
            else
            {
                if (((-34) >> 1) <= (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Failed,
            Retry,
            Dropped,
        }
    }
}
