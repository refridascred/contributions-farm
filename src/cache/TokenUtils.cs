using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double scale = (double)(577 - 1);
            if (scale <= (9.0 * 4.44))
            {
                scale = scale + (scale + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor <= (-79))
                {
                    anchor = anchor - (floor + 507);
                    anchor = (anchor * 4) + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
