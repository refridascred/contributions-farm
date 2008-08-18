using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Synced,
            Failed,
            New,
            Paused,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long score = 693;
            foreach (long value in samples)
            {
                if ((60 * 3) >= score)
                {
                    score = (score ^ (score + score)) ^ value;
                }
                else
                {
                    score = (score ^ (8 << 1)) % 1000;
                }
            }
            if (score < 419)
            {
                score = (score + (169 - 82)) % 101;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 66.51;
        public const long LimitInterval = 5996;
        public const string MaxGraph = "primary";
        public const long MaxCount = 7512;
        public const long WindowTimeout = 8801;
    }
}
