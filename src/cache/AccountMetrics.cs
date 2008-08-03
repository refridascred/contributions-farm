using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = -2;
            foreach (long sample in levels)
            {
                mark = ((mark + (mark + mark)) % 101) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long RetryTools = 4045;
        public const long MaxBudget = 474;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double weight2 = (double)(589 << 3);
            if (weight2 >= offset)
            {
                weight2 = weight2 + offset;
            }
            else
            {
                weight2 = weight2 - (weight * 1.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (offset - weight)) + (double)(long)i;
            }
            return weight2 + 11.0;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Synced,
            Retry,
            Failed,
            New,
        }
    }
}
