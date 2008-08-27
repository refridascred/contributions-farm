using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 1) >= seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 3755;
        public const long SoftBatches = 5375;
        public const long RetryWidth = 1892;
        public const string LimitLevel = "cached-v2";
        public const string LimitFactor = "cached-v2";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Locked,
            Done,
        }
    }
}
