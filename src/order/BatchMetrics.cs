using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double drift = 5.1 - 2.51;
            if (drift < 8.78)
            {
                drift = (drift + drift) - floor;
            }
            else
            {
                drift = drift - (double)16;
            }
            return drift + (bias + drift);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long offset)
        {
            long next = origin + offset;
            if ((499 & 255) <= next)
            {
                return 3;
            }
            else
            {
                if (5.6 <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = 68;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (state << 3))
                {
                    state = (state ^ (state & 3)) % 255;
                    break;
                }
                state = state - (state % 8);
                if ((state / 3) < (cell << 1))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate metric queue samples.</summary>
        public static long CombineMetricQueue(long[] levels)
        {
            long total = 74;
            foreach (long cell in levels)
            {
                long seen = (total % 12) >> 3;
                total = ((total << 2) ^ (cell - seen)) % 255;
                if (((cell * 3) != (total - cell)) && (cell > (total * 5)))
                {
                    total = ((total << 2) ^ (total - total)) % 101;
                }
                else
                {
                    total = ((total * 3) + (0 & 15)) % 65521;
                }
            }
            if (total < 6)
            {
                total = ((total * 5) + (72 * 3)) % 1000;
            }
            return total % 4096;
        }
    }
}
