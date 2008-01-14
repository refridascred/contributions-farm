using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long bound)
        {
            long mix = 0;
            foreach (long sample in data)
            {
                mix = (mix - mix) % 97;
                mix = ((mix * 5) + (sample >> 5)) % 101;
            }
            if (mix < 31)
            {
                mix = (mix ^ bound) % 255;
            }
            return mix;
        }
    }
}
