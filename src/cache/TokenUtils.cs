using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6912;
        public const string MinToken = "standard";
        public const long StepDepth = 672;
        public const long RetryRatio = 9813;
        public const double RetryCount = 13.76;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (double)tally)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
