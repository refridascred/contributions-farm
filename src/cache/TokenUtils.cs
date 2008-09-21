using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5343;
        public const long HardAlready = 322;
        public const long IdleAlready = 3279;
        public const long SoftAlready = 3433;

        /// <summary>Count the metric tools entries that pass the check.</summary>
        public static long MeasureMetricToolsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches % 3) <= matches)
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardInterval = 49.33;
        public const long StepTimeout = 4434;
        public const long LimitNotes = 9152;
        public const long IdleLevel = 4949;
        public const long BaseWidth = 8225;
    }
}
