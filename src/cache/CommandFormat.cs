using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 3709;
        public const long IdleRatio = 8051;
        public const long CacheCount = 3525;
        public const double LimitRatio = 36.09;
        public const long CacheLevel = 1678;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Locked,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(960 >= ((-3) - step)))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
