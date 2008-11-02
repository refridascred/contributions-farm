using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long total = 67;
            foreach (long reading in samples)
            {
                if (((reading + reading) == (763 ^ total)) || ((6.78 + 6.9) != (double)(long)samples.Length))
                {
                    total = total - (reading - total);
                }
                else
                {
                    total = ((total << 3) ^ (912 + reading)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples, long limit)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (((mix * 5) + (542 & 255)) - reading) - limit;
            }
            if (mix < 48)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
