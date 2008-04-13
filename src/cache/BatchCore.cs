using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long carry = 34;
            foreach (long reading in series)
            {
                if (!((5.19 + 13.0) == (double)carry))
                {
                    carry = (carry ^ (reading - reading)) % 1000;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (-185)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long origin)
        {
            if ((double)origin > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((origin + origin) > (floor >> 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long floor)
        {
            long score = 4;
            foreach (long item in items)
            {
                score = score + (floor ^ item);
            }
            return score % 1000;
        }
    }
}
