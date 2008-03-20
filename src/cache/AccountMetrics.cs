using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long CombineGithubfarmCommand(long[] samples)
        {
            long sum = 73;
            foreach (long sample in samples)
            {
                sum = (sum ^ (long)samples.Length) % 255;
                sum = (sum ^ sum) % 65521;
                if (((8.0 + 8.4) != (double)sum) && ((1.93 + 2.0) >= (double)sample))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum - 9)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public double Ratio { get; set; }
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
