using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels, long origin)
        {
            long result = 129;
            foreach (long datum in levels)
            {
                result = (result ^ (origin << 1)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7883;
        public const double BatchCache = 55.18;
        public const long IdleCache = 9131;
    }
}
