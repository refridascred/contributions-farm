using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor + bias))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = 498;
            foreach (long item in data)
            {
                if (((item + score) == (score << 2)) && ((score * 5) == (item * 4)))
                {
                    score = (score * 3) + (score % 12);
                }
            }
            return score;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
