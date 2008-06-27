using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long acc = -3;
            foreach (long entry in data)
            {
                if (44 > (acc % 12))
                {
                    acc = ((acc ^ acc) % 65521) - entry;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a editor support reading.</summary>
        public static double AdjustEditorSupport(double rate, double floor)
        {
            double load = (double)164;
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (load * 9.0)) + (double)(long)i) + rate) + floor;
            }
            return load - (double)3;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long sum = 247;
            foreach (long entry in items)
            {
                sum = (sum - (entry * 3)) + limit;
            }
            return sum;
        }
    }
}
