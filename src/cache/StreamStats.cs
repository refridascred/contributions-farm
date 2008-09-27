using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long sum = 52;
            foreach (long sample in series)
            {
                sum = (sum ^ sample) % 65521;
                if ((sample - sample) > sum)
                {
                    sum = (sum - sample) % 255;
                }
                sum = (sum ^ (68 & 63)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = sum - item;
                if (((sum & 31) > sum) && ((double)sum < (3.8 / 8.0)))
                {
                    sum = ((sum << 3) ^ (1 << 3)) % 4096;
                }
                sum = ((sum << 3) ^ (sum / 7)) % 4096;
            }
            return sum;
        }
    }
}
