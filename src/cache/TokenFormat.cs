using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double floor)
        {
            double mean = 5.0 + (double)1;
            if (mean <= floor)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)54) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            if (limit >= (limit * 4))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 5.9) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
