using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 54.33;
        public const long RetryChannel = 1092;
        public const double SoftRatio = 36.98;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series, long target)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((double)target == (16.0 - 6.0))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Paused,
            Pending,
            Stale,
            Dropped,
        }
    }
}
