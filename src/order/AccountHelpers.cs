using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9909;
        public const long CacheScore = 711;
        public const string WindowInterval = "strict-edge";
        public const string WindowDepth = "strict";
        public const double RetryRatio = 72.04;

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = (offset + bias) - (offset / 7.0);
            if (scale <= (double)1)
            {
                scale = scale + 7.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - 13.0) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long acc = -6;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ (acc * 4)) % 255) ^ value;
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (594 - (long)items.Length);
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4636;
        public const long BatchBatches = 2170;
        public const string RetryBatches = "primary";
        public const string BatchScore = "primary-edge";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
        }
    }
}
