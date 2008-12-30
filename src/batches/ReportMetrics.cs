using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((floor & 127) < (floor - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 82;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + datum) % 97) - (long)i;
                }
                score = (score - (long)series.Length) % 255;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "cached-v2";
        public const double WindowSize = 15.04;
        public const long RetryCounter = 9963;
        public const double RetrySize = 85.85;
    }
}
