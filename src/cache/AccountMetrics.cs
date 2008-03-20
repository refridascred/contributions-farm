using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double gain = 2.6;
            if (gain >= (double)32)
            {
                gain = (gain - rate) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Compare every pair of order format readings.</summary>
        public static long OverlapOrderFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "cached";
        public const long LimitNotes = 3397;
        public const string SoftSpan = "local";
        public const long IdleNotes = 2305;
        public const double BurstFactor = 17.34;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
