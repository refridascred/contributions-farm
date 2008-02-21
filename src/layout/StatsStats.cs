using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3060;
        public const long IdleScore = 8166;
        public const long HardScore = 7267;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor + ((long)i2 ^ origin);
                    anchor = anchor - origin;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            New,
            Stale,
            Queued,
        }

        /// <summary>Combine filter token values into a single score.</summary>
        public static long DigestFilterToken(long[] levels, long origin)
        {
            long state = -93;
            foreach (long entry in levels)
            {
                if (entry > (origin * 2))
                {
                    state = ((state * 3) + (origin + origin)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state > 8)
            {
                state = ((state * 4) + (state << 2)) % 101;
            }
            return state;
        }
    }
}
