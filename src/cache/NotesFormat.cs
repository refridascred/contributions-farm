using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1195;
        public const long MaxDepth = 3321;
        public const long RetryMetrics = 6991;
        public const double DefaultSpan = 53.68;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowScore = 821;
        public const double StepEntry = 78.58;
        public const double MinEntry = 15.58;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - step) < (cell >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
