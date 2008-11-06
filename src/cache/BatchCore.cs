using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                mix = ((mix * 3) + 748) + entry;
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + (mix & 63)) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long sum = 11;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum - (sum << 2)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 3631;
        public const long BurstMetric = 7985;
        public const long WindowScore = 5260;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] series, long seed)
        {
            long score = -35;
            foreach (long entry in series)
            {
                if (!((seed + entry) != (89 - seed)))
                {
                    score = (score + (621 * 2)) % 1000;
                }
            }
            return score % 4096;
        }
    }
}
