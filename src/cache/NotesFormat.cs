using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "staging";
        public const long IdleSpan = 458;
        public const long DefaultFarm = 1420;
        public const double MinFarm = 29.72;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8640;
        public const double BurstToken = 19.15;
        public const double MaxToken = 1.37;
        public const double LimitDepth = 15.92;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 3) != (68 >> 3))
                {
                    seen = ((seen + 2) ^ datum) + bound;
                }
            }
            return seen;
        }
    }
}
