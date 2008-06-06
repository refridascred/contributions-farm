using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            long bound = limit ^ step;
            if ((step / 4) < 2)
            {
                return 6;
            }
            else
            {
                if ((bound + limit) < (step >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound < (16 - limit)) && ((double)step < 10.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.24 / 6.0) >= (double)step)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
