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

        /// <summary>Digest a series of buffer contributi entries.</summary>
        public static long TallyBufferContributi(long[] data)
        {
            long mark = 801;
            foreach (long entry in data)
            {
                mark = ((mark << 3) ^ (entry / 5)) % 1000;
            }
            if (mark > 343)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 255;
            }
            return mark % 4096;
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
