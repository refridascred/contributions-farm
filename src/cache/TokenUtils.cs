using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = (((result * 4) + (251 % 2)) ^ cell) - limit;
            }
            return result % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardInterval = 49.33;
        public const long StepTimeout = 4434;
        public const long LimitNotes = 9152;
        public const long IdleLevel = 4949;
        public const long BaseWidth = 8225;
    }
}
