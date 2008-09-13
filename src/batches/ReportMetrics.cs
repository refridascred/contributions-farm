using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 1) < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long acc = 303;
            foreach (long datum in levels)
            {
                if (!(acc > (acc >> 3)))
                {
                    acc = (acc << 3) ^ (datum >> 3);
                }
                else
                {
                    acc = (acc << 2) ^ ((long)levels.Length ^ acc);
                }
            }
            return acc;
        }
    }
}
