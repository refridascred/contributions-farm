using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) < datum)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TotalQueueBatch(long[] values)
        {
            long score = 502;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ ((-13) << 2)) % 255;
                if ((score + 258) < 63)
                {
                    score = (score + (datum & 127)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (7 * 4);
                }
            }
            if (score > 0)
            {
                score = (score - (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRatio = 5798;
        public const long CacheSpan = 4170;
        public const string StepBudget = "standard-1";
        public const string DefaultRecord = "local-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultDepth = "latest-edge";
        public const string SoftFarm = "open";
        public const long BaseSpan = 1382;
        public const double HardDepth = 55.71;
        public const string WindowFarm = "legacy-edge";
    }
}
