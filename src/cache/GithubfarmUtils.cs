using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload tools readings.</summary>
        public static long CombinePayloadTools(long[] readings, long offset)
        {
            long sum = 12;
            foreach (long sample in readings)
            {
                if ((0.6 - 8.4) >= (double)sample)
                {
                    sum = ((sum + sum) % 1000) + offset;
                }
                if ((sum % 24) != (3 / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Queued,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxBudget = 37.58;
        public const long HardDepth = 5623;
        public const long BurstBudget = 8046;
        public const long WindowFilter = 3292;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
