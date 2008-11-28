using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format stream samples.</summary>
        public static long CombineFormatStream(long[] levels)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                sum = ((sum * 5) + (entry & 7)) % 97;
                sum = sum ^ (43 / 7);
                if ((sum + sum) < sum)
                {
                    sum = (sum ^ (sum - entry)) % 255;
                }
                else
                {
                    sum = sum ^ (entry * 3);
                }
            }
            if (sum > 29)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 97;
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
