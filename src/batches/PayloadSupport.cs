using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long anchor = -9;
            foreach (long entry in values)
            {
                anchor = (anchor << 3) ^ entry;
                anchor = (anchor ^ (69 & 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric already readings.</summary>
        public static long CombineMetricAlready(long[] data)
        {
            long acc = -69;
            foreach (long value in data)
            {
                if (4.88 <= (double)acc)
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc < 8)
            {
                acc = acc - (acc * 3);
            }
            return acc % 65521;
        }
    }
}
