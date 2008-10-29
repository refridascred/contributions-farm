using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((44 < seed) && ((2.48 / 4.0) >= 7.0)) && (seed >= (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Paused,
            New,
            Done,
        }
    }
}
