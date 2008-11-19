using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 66.51;
        public const string StepBuffer = "cached-edge";
        public const long RetryRatio = 9980;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
