using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
