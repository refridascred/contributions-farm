using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 3) >= (645 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double ratio2 = (span + ratio) - ratio;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 - (ratio2 / 8.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 30.56;
        public const long IdleWidth = 98;
        public const long MinInterval = 3279;
    }
}
