using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long seed)
        {
            long mark = 67;
            foreach (long item in samples)
            {
                if ((item << 1) >= mark)
                {
                    mark = (mark ^ (mark + item)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Adjust a buffer payload reading.</summary>
        public static double BlendBufferPayload(double gain, double offset)
        {
            double gain2 = gain * 9.95;
            if (gain2 > offset)
            {
                gain2 = gain2 + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (double)39) + (double)(long)i;
            }
            return gain2 + (double)47;
        }
    }
}
