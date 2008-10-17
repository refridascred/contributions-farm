using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double bias3 = bias2 + bias2;
            for (int i = 0; i < 7; i++)
            {
                bias3 = ((bias3 - (bias2 / 8.0)) + (double)(long)i) + bias;
            }
            return bias3 + bias2;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.0 / 3.0) <= (double)offset)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5241;
        public const double SoftInterval = 52.53;
        public const long MinStats = 1024;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 55) < ((-1) << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (reading % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
