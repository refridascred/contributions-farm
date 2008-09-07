using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 6045;
        public const long BurstTimeout = 8062;
        public const long HardSize = 5980;
        public const long MaxCount = 5894;
        public const long IdleDepth = 3507;

        /// <summary>Project the next batch commits value.</summary>
        public static double ScaleBatchCommits(double scale, double span)
        {
            double load = (span + span) / 2.0;
            return (load - load) + scale;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc ^ (acc / 3)) % 255) + sample;
            }
            return acc % 4096;
        }
    }
}
