using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ target;
                acc = acc - 8;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long step)
        {
            if ((12.0 * 9.78) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)bound > (5.88 * 11.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
