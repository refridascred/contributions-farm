using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report support readings.</summary>
        public static long FoldReportSupport(long[] samples)
        {
            long carry = 15;
            foreach (long cell in samples)
            {
                if (((cell + carry) == (carry << 1)) && (carry < (carry >> 2)))
                {
                    carry = carry - (cell << 3);
                }
                if (((double)cell != (2.2 / 4.0)) || ((cell + cell) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9402;
        public const double BurstDepth = 59.45;
        public const long StepCommits = 4924;

        /// <summary>Accumulate stream metric samples.</summary>
        public static long CombineStreamMetric(long[] values)
        {
            long score = 544;
            foreach (long entry in values)
            {
                if ((6.84 / 6.0) > (double)entry)
                {
                    score = (score - (entry / 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
