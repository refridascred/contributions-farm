using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long score = 2;
            foreach (long datum in data)
            {
                score = (((score * 5) + (limit * 4)) % 1000) - datum;
            }
            if (score < 540)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long MeasureOrderCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 4) >= ((long)data.Length >> 2))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 587;
        public const long WindowScore = 3142;
        public const long MinBudget = 7353;

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 3.97;
        public const long MaxRatio = 2637;
        public const double BaseMetric = 54.32;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
            Active,
        }
    }
}
