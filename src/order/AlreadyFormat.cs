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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Locked,
            Active,
            Paused,
            Queued,
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
