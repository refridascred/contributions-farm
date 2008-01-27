using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double scale = (double)(-850) + span;
            return (scale + 8.82) + rate;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) != (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 2321;
        public const long CacheInterval = 387;
        public const long DefaultAlready = 9687;
    }
}
