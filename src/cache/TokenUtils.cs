using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue editor samples.</summary>
        public static long TotalQueueEditor(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (entry > (mix << 3))
                {
                    mix = mix ^ (94 + target);
                }
            }
            if (mix < 18)
            {
                mix = mix + (417 + mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Scale a buffer schema figure with a bias.</summary>
        public static double AdjustBufferSchema(double gain, double span)
        {
            double gain2 = (double)(5 << 3);
            for (int i = 0; i < 9; i++)
            {
                gain2 = ((gain2 - (span + 5.4)) - (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 8.24);
        }
    }
}
