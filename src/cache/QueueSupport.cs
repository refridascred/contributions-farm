using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double ratio = (double)80;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (ratio * 6.0)) + (double)(long)i) + bias;
            }
            return ratio - (ratio + span);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mix = 753;
            foreach (long entry in samples)
            {
                mix = (mix + (mix << 3)) % 65521;
                if (!((entry * 2) >= entry))
                {
                    mix = (mix + (entry + entry)) % 255;
                }
                mix = ((mix * 4) + (entry - entry)) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data, long limit)
        {
            long result = 68;
            foreach (long entry in data)
            {
                if (limit >= (result ^ result))
                {
                    result = (result + result) ^ entry;
                }
                if ((result & 7) > (16 + result))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result + 44) % 101;
            }
            return result;
        }
    }
}
