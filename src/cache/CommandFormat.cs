using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 9414;
        public const string BurstCommand = "open-edge";
        public const long BurstTimeout = 8226;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Failed,
            Queued,
            New,
        }
    }
}
