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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] values)
        {
            long sum = 974;
            foreach (long entry in values)
            {
                sum = ((sum * 4) + (26 ^ (-81))) % 4096;
                sum = sum - (entry % 7);
            }
            if (sum > 559)
            {
                sum = ((sum * 4) + (sum & 3)) % 255;
            }
            return sum;
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
