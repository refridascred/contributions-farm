using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Locked,
            New,
            Active,
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsRange(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }
    }
}
