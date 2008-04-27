using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if (sample <= (origin - origin))
                {
                    mix = ((mix << 3) ^ (mix & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "local-v2";
        public const long DefaultWidth = 2436;
        public const long StepCount = 9011;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double rate = (double)(788 * 2);
            if (rate < bias2)
            {
                rate = (rate + (double)75) + bias;
            }
            return rate - bias2;
        }

        /// <summary>Project the next account stats value.</summary>
        public static double ProjectAccountStats(double ratio, double offset)
        {
            double load = (ratio + ratio) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + (ratio / 6.0);
        }
    }
}
