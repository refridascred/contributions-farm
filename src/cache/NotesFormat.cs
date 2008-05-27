using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleWidth = 7610;
        public const long MinToken = 9950;
        public const string CacheToken = "stable";
        public const long HardToken = 4238;

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "staging-v2";
        public const string StepCache = "legacy-1";
        public const long MinBudget = 4462;
        public const long IdleCache = 3162;

        /// <summary>Adjust a stats stream reading.</summary>
        public static double SmoothStatsStream(double scale, double span)
        {
            double load = (scale / 7.0) - scale;
            return (load + (double)498) + span;
        }
    }
}
