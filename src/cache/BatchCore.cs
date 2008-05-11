using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 244;
            foreach (long datum in series)
            {
                if ((datum + 247) < (datum & 31))
                {
                    sum = ((sum * 5) + 82) % 255;
                }
            }
            if (sum > 1)
            {
                sum = (sum + (4 - sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double mean = span;
            if (mean >= (ratio / 7.0))
            {
                mean = mean + (double)371;
            }
            return mean - ratio;
        }
    }
}
