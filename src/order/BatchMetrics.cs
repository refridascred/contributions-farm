using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long delta = origin + step;
            if ((0 ^ step) == (9 << 2))
            {
                return 0;
            }
            else
            {
                if (!((double)delta < (0.94 + 2.42)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a session batches figure with a bias.</summary>
        public static double ScaleSessionBatches(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)0)
            {
                scale2 = scale2 + (floor * 5.31);
            }
            return scale2 - (floor - floor);
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count checks cluster pairs that satisfy a relation.</summary>
        public static long OverlapChecksClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
