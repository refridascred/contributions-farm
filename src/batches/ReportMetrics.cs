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

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 25;
            foreach (long item in readings)
            {
                if (((item << 1) <= 341) || ((item + mix) > (113 ^ mix)))
                {
                    mix = ((mix * 3) + (item - 2)) % 255;
                }
            }
            return mix % 97;
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
