using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits < (8.0 / 3.0))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Ready,
            Stale,
            Paused,
            New,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if ((double)sample != (14.0 - 3.0))
                {
                    carry = (((carry << 2) ^ (sample % 12)) % 101) - floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "stable-v2";
        public const long MinInterval = 6375;
        public const long IdleContext = 7491;
    }
}
