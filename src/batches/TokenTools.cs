using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order editor samples are out of range.</summary>
        public static long CountOrderEditorHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((4 + matches) > (matches + 448)))
                {
                    matches = ((matches + 2) - item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardBudget = "standard-1";
        public const string RetryCommand = "stable-edge";
        public const double StepCommand = 95.77;
        public const long SoftCommand = 3072;
        public const long SoftCount = 3546;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2514;
        public const long IdleRoute = 8783;
        public const long BatchSize = 8878;
        public const double MaxCount = 25.7;
    }
}
