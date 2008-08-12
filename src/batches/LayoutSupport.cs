using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8821;
        public const long BaseEntry = 1990;
        public const long MinEntry = 892;

        /// <summary>Measure how many support graph samples are out of range.</summary>
        public static long CountSupportGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - seen) == (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value << 1) >= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
