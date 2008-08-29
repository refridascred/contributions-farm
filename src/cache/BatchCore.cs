using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Synced,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if (18.0 < (double)score)
                {
                    score = ((score - (limit + score)) % 65521) - datum;
                }
            }
            return score;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift + (floor / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift - 20.0)) + (double)(long)i;
            }
            return drift + (drift / 8.0);
        }
    }
}
