using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 88.95;
        public const long LimitBatch = 3244;
        public const long BaseLevel = 8386;
        public const double WindowScore = 44.23;
        public const long HardSize = 6150;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((1.7 - 3.39) < (double)limit))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryBudget = 83.0;
        public const double RetrySpan = 5.07;
        public const double MinCount = 71.66;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long step)
        {
            if (((720 + step) == (bound - step)) && ((0.6 - 13.0) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if (((3.0 / 5.0) <= (double)step) || ((bound % 8) < (step ^ step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long score = -77;
            foreach (long item in data)
            {
                if (!((16.0 + 8.0) <= (double)score))
                {
                    score = (score << 3) ^ item;
                }
            }
            return score % 4096;
        }
    }
}
