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

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample * 4);
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 30.56;
        public const long IdleWidth = 98;
        public const long MinInterval = 3279;
    }
}
