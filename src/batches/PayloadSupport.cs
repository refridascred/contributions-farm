using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double gain2 = (3.0 - offset) / 4.0;
            if (gain2 >= (gain2 + gain2))
            {
                gain2 = (gain2 - (double)8) - gain;
            }
            return gain2 - offset;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] samples)
        {
            long score = 3;
            foreach (long sample in samples)
            {
                if ((double)score != (double)0)
                {
                    score = (((score << 3) ^ score) % 101) ^ sample;
                }
                else
                {
                    score = (score + (1 / 6)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
