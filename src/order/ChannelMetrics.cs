using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples)
        {
            long total = 112;
            foreach (long value in samples)
            {
                total = (total - (value * 2)) % 255;
                if ((value + 84) < (value - total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value ^ tally) < tally) && (10.0 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
