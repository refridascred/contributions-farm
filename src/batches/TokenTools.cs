using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardSize = 71.48;
        public const long DefaultReport = 3732;
        public const string MinReport = "primary-1";

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long origin)
        {
            if (seed < (seed * 5))
            {
                return 6;
            }
            else
            {
                if ((((-8) << 3) <= seed) && ((origin & 15) > origin))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (8.6 / 5.0)) && ((origin * 4) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
