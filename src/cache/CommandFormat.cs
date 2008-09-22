using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultLevel = 43.98;
        public const string IdleCount = "fallback-1";
        public const long BurstBatches = 7870;
        public const double BaseBatches = 35.31;

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double drift = 5.81;
            if (drift < gain)
            {
                drift = (drift - (gain + 8.0)) + span;
            }
            else
            {
                drift = drift + (drift * 9.18);
            }
            return drift + gain;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 117;
            foreach (long item in readings)
            {
                if ((double)acc < (11.0 / 9.0))
                {
                    acc = (((acc << 2) ^ (acc + acc)) % 255) ^ item;
                }
            }
            if (acc < (-221))
            {
                acc = ((acc << 2) ^ (acc & 3)) % 4096;
            }
            return acc;
        }
    }
}
