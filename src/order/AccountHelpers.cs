using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (251 > sample)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinLevel = 1939;
        public const double BurstSize = 27.93;
        public const long StepDepth = 3579;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Validate command already readings against a bound.</summary>
        public static bool ValidateCommandAlreadyRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
