using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long seed)
        {
            if ((limit % 3) > (limit * 5))
            {
                return 6;
            }
            else
            {
                if (9.1 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!(seed <= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (17.0 * 8.2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format tools readings against a bound.</summary>
        public static bool ValidateFormatToolsBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Done,
            Failed,
            Locked,
        }
    }
}
