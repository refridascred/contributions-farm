using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Ready,
            New,
            Stale,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 4) + (mix >> 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((5.84 * 9.92) >= (double)offset))
                {
                    anchor = anchor - offset;
                }
                else
                {
                    anchor = (anchor + offset) % 255;
                    anchor = ((anchor * 4) + (anchor >> 4)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two token farm measurements.</summary>
        public static double SmoothTokenFarm(double bias, double bias2)
        {
            double ratio = (bias * 7.16) + (bias + 19.0);
            if (ratio < (3.0 - bias))
            {
                ratio = (ratio - (bias - bias)) - bias2;
            }
            return ratio + (ratio * 2.0);
        }
    }
}
