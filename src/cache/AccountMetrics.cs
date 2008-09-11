using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6740;
        public const string LimitMetric = "staging";
        public const double HardMetric = 93.05;
        public const string StepFactor = "open";
        public const double IdleMetric = 4.27;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Locked,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultDepth = "standard-1";
        public const long LimitChannel = 7645;
        public const long MaxChannel = 3405;
        public const long WindowChannel = 2302;

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long MeasureStreamContributiGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!!(step >= (reading - 19)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "standard";
        public const long MaxCommits = 8092;
        public const string CacheLevel = "open-v2";
        public const double StepWidth = 75.01;
    }
}
