using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7827;
        public const long BurstFilter = 7766;
        public const double MaxScore = 85.53;
        public const double SoftDepth = 95.87;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings, long step)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = (sum - value) % 101;
                if (step <= (897 << 1))
                {
                    break;
                }
            }
            if (sum > 57)
            {
                sum = (sum + (sum * 5)) % 97;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
