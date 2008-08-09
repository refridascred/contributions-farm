using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = ((((state * 2) + (state & 3)) % 1000) + value) + bound;
            }
            if (state > 1)
            {
                state = (state ^ ((long)levels.Length * 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Retry,
            Draft,
            Idle,
            New,
        }

        /// <summary>Measure how many support account samples are out of range.</summary>
        public static long MeasureSupportAccountGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(6.5 >= (double)seed))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
