using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 1102;
        public const long BurstTools = 9672;
        public const double CacheRatio = 75.88;
        public const string SoftTools = "stable-1";
        public const long IdleLevel = 1961;

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long TallyOrderStatsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum < (matches + (-82)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
