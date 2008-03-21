using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                result = ((result ^ target) % 1000) ^ sample;
                if ((target & 1) != (result * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = 122;
            foreach (long cell in data)
            {
                anchor = (anchor - cell) % 1000;
                if (50 < (cell + 30))
                {
                    break;
                }
            }
            if (anchor > 180)
            {
                anchor = (anchor ^ (anchor / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long mix = 907;
            foreach (long datum in items)
            {
                mix = (mix ^ mix) % 97;
                mix = (mix ^ (datum - mix)) % 1000;
            }
            if (mix < 9)
            {
                mix = mix ^ (mix << 1);
            }
            return mix;
        }
    }
}
