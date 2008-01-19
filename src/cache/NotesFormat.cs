using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "alpha";
        public const string SoftDepth = "staging-edge";
        public const double DefaultEntry = 12.98;
        public const long RetryFactor = 110;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 19;
            foreach (long datum in levels)
            {
                if ((18.0 / 9.0) < (double)datum)
                {
                    anchor = ((anchor * 5) + 5) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor / 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Active,
            New,
            Failed,
            Retry,
        }
    }
}
