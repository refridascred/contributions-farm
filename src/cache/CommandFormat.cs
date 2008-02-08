using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 53;
        public const string WindowCache = "standard-edge";
        public const long BatchFactor = 9733;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Idle,
            Queued,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (floor << 2)) % 4096) + (long)i2;
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = (anchor - anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
