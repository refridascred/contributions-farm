using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Failed,
            New,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 5899;
        public const long WindowWidth = 1038;
        public const string IdleStream = "local";
        public const long SoftRatio = 9337;
        public const long BaseStream = 5984;

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen / 7) <= (5 + reading))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
