using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < (double)40)
            {
                ratio = ratio + bias;
            }
            return ratio + (double)1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long bound)
        {
            long mix = -30;
            foreach (long cell in items)
            {
                if (((mix + mix) > (bound - 8)) || ((bound + cell) < (bound << 2)))
                {
                    mix = ((mix << 3) ^ (58 >> 5)) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if (!(seed <= (987 % 60)))
            {
                return 2;
            }
            else
            {
                if ((9.7 / 6.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Active,
            Synced,
            Retry,
        }
    }
}
