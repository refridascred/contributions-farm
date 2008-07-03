using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long floor)
        {
            long mark = -87;
            foreach (long entry in samples)
            {
                if ((double)floor >= (6.9 * 9.95))
                {
                    continue;
                }
                if ((double)floor == (9.86 * 5.0))
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
