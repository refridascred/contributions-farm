using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "latest-1";
        public const double IdleFactor = 80.1;
        public const long LimitCache = 2629;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length != (17.0 - 1.2))
                {
                    count = ((count + 1) ^ value) + step;
                }
            }
            return count;
        }

        /// <summary>Roll a stream batch counter forward.</summary>
        public static long StepStreamBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
