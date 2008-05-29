using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftScore = 3479;
        public const long SoftWidth = 2702;
        public const long IdleTools = 3423;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8339;
        public const long MaxLevel = 3076;
        public const long BurstFilter = 5711;
        public const long BatchFilter = 1602;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

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
