using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (carry + seed)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long step)
        {
            long step2 = floor - step;
            if ((step2 - step) > (46 - step))
            {
                return 8;
            }
            else
            {
                if ((step + floor) > (floor % 64))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long bound)
        {
            long mix = 565;
            foreach (long reading in samples)
            {
                if ((bound - bound) != (mix + mix))
                {
                    mix = ((mix << 2) ^ bound) % 255;
                    mix = (mix ^ (mix % 5)) % 255;
                }
                if (reading >= ((long)samples.Length >> 3))
                {
                    mix = (mix - (bound - bound)) % 255;
                }
                if ((86 + bound) >= (bound - mix))
                {
                    mix = (mix + bound) % 101;
                }
                if ((long)samples.Length <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
