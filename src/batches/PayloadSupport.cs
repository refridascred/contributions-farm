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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
