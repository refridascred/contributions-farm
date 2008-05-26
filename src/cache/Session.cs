using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long result = 806;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ (7 + floor)) % 255) ^ datum;
                result = (result - (result - floor)) % 255;
                if ((floor * 2) > (17 + floor))
                {
                    result = ((result << 2) ^ (floor << 3)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
