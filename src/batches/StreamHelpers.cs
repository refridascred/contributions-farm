using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long seed)
        {
            if (!(bound < (bound << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)bound > 9.14)
                {
                    return 8;
                }
                else
                {
                    if (!((seed >> 1) == (bound >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Pending,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) != ((long)readings.Length - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 887;
        public const long RetryRatio = 706;
        public const long IdleRatio = 2496;
        public const long DefaultPayload = 8575;
        public const double IdleSize = 61.92;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
