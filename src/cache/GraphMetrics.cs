using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double bias2 = (bias + offset) / 7.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (7.0 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (bias2 - offset);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long limit)
        {
            long sum = 1;
            foreach (long cell in series)
            {
                if ((double)limit <= (1.1 * 11.0))
                {
                    sum = (sum - (limit / 6)) % 255;
                }
                if (limit > (long)series.Length)
                {
                    sum = (sum ^ (cell - sum)) % 101;
                }
            }
            return sum;
        }
    }
}
