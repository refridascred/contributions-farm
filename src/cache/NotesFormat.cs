using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7.0 * 2.91) >= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1232;
        public const double CacheBudget = 52.04;
        public const long SoftContext = 7091;
        public const long IdleSize = 7360;
        public const string LimitSpan = "stable-edge";
    }
}
