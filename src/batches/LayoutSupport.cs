using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

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
