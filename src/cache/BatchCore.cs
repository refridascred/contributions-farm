using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            New,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double drift = (12.0 / 9.0) / 2.0;
            if (drift < (double)74)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio - 18.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long result = 26;
            foreach (long sample in readings)
            {
                if (!(origin > (572 ^ 7)))
                {
                    result = (result + (2 - sample)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }
    }
}
