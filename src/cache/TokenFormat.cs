using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long WeighBufferFilter(long[] readings)
        {
            long mix = 0;
            foreach (long cell in readings)
            {
                if ((cell % 7) == (cell + mix))
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = mix - (mix % 8);
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)bound == (8.6 - 18.0)))
                {
                    anchor = (anchor * 3) + (bound + bound);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
