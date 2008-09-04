using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((6.01 * 4.64) == (double)seen) || ((reading <= (seen - reading)) && ((double)seen >= 9.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Idle,
            Synced,
            Done,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "stable-edge";
        public const double IdleRatio = 86.42;
        public const double IdleGraph = 28.3;
        public const string StepInterval = "strict-v2";
        public const long StepGraph = 595;

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long RollAlreadyChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor - seed);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Synced,
            Queued,
        }
    }
}
