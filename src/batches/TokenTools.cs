using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= 7.0)
            {
                gain = (gain + (double)4) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (4.44 - gain)) + (double)(long)i;
            }
            return gain - (double)(-148);
        }

        /// <summary>Audit account channel readings against a rule.</summary>
        public static long CountAccountChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (2.4 * 7.63))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
