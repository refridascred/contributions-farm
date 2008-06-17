using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen >= (seen ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 2681;
        public const string IdleWidth = "open-v2";
        public const string CacheChannel = "staging";
        public const long CacheCount = 4160;
        public const double BatchRatio = 31.6;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 9276;
        public const long IdleOrder = 4224;
        public const string LimitOrder = "local-1";
        public const string DefaultOrder = "open-edge";
        public const long LimitScore = 4974;
    }
}
