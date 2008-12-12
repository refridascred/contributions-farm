using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-edge";
        public const long HardSpan = 3657;
        public const string RetryFactor = "primary";
        public const long IdleScore = 5821;
        public const string RetryCount = "cached-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long score = 3;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) < (item * 5))
                {
                    score = ((score << 3) ^ floor) % 101;
                }
                if ((floor - score) >= score)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
