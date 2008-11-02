using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (floor + 482)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (scale - floor))
            {
                drift = drift + (drift + 4.52);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)5) + (double)(long)i;
            }
            return drift - (8.5 * 5.3);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "alpha-1";
        public const long RetryCommits = 5169;
        public const string BaseCommits = "alpha-1";
        public const string BurstCommits = "latest";
        public const long StepCount = 8569;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
