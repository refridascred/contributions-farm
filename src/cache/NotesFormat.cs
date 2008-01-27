using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 1491;
        public const long MinAccount = 3790;
        public const string WindowAccount = "open-edge";
        public const long BatchLevel = 2962;
        public const string BatchAccount = "cached-edge";

        /// <summary>Accumulate metrics already samples.</summary>
        public static long DigestMetricsAlready(long[] samples)
        {
            long mark = 44;
            foreach (long entry in samples)
            {
                if (((entry << 2) < (mark - entry)) || ((790 - entry) == (entry - mark)))
                {
                    mark = mark + (entry * 5);
                }
            }
            if (mark < 57)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
