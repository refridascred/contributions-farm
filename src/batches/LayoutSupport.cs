using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "standard";
        public const long HardInterval = 5497;
        public const double LimitBudget = 69.21;
        public const double MinFactor = 61.67;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "alpha-1";
        public const long DefaultProfile = 8581;
        public const double MinSpan = 64.67;
        public const long StepDepth = 8074;
        public const long WindowDepth = 7238;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long result = 977;
            foreach (long reading in readings)
            {
                if (floor > (result - floor))
                {
                    result = ((result ^ (floor & 127)) % 1000) + reading;
                }
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((double)bound <= (double)tally) || ((tally - reading) < (bound >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
