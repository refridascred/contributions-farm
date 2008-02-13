using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum / 5))
                {
                    anchor = (anchor * 2) + 36;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)items.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Audit record already readings against a rule.</summary>
        public static long CountRecordAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 7) <= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metric record measurements.</summary>
        public static double ProjectMetricRecord(double ratio, double span)
        {
            double gain = (double)(9 % 8);
            if (gain <= gain)
            {
                gain = (gain + ratio) - span;
            }
            return gain + 10.0;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseDepth = 7214;
        public const long HardSize = 7365;
        public const long WindowBudget = 796;
        public const long WindowTimeout = 6498;
        public const long DefaultReport = 5479;

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            long delta = bound - offset;
            if ((delta % 12) <= offset)
            {
                return 6;
            }
            else
            {
                if (delta > bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
