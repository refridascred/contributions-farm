using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 56;
            foreach (long sample in samples)
            {
                if (!((double)0 < (double)score))
                {
                    score = ((score + (269 * 2)) % 65521) ^ sample;
                }
            }
            return score % 4096;
        }
    }
}
