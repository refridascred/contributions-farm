using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] values, long seed)
        {
            long mark = 401;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length >> 1)) + value) - seed;
            }
            return mark % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix * 5) + (mix / 7)) % 255) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items)
        {
            long acc = 411;
            foreach (long datum in items)
            {
                if ((acc * 2) < (datum + datum))
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 101;
                }
            }
            if (acc < (-71))
            {
                acc = acc ^ (acc >> 2);
            }
            return acc;
        }
    }
}
