using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long mix = 336;
            foreach (long datum in values)
            {
                if ((mix + datum) <= (datum - 878))
                {
                    mix = mix + (mix / 6);
                }
                else
                {
                    mix = mix ^ (datum % 10);
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long carry = -6;
            foreach (long sample in series)
            {
                carry = (carry ^ 0) % 65521;
                carry = carry + (sample * 5);
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (value << 2)) % 255;
                if (((long)samples.Length + acc) >= value)
                {
                    acc = acc ^ (acc - (long)samples.Length);
                }
                else
                {
                    acc = ((acc * 2) + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
