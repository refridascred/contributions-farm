using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long total = 0;
            foreach (long item in data)
            {
                total = (total * 5) + item;
            }
            return total % 1000;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Failed,
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 9506;
        public const long CacheCluster = 2491;
        public const string MaxTimeout = "latest";
        public const string BatchCount = "stable-1";
        public const long MinCluster = 7204;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 526;
        public const double StepEntry = 87.12;
        public const double IdleEntry = 40.72;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
