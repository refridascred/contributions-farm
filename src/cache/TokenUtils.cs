using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "open-1";
        public const double WindowInterval = 55.44;
        public const string WindowAlready = "primary";
        public const string BurstAlready = "open-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if ((limit % 97) < origin)
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) <= (limit - 5))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 127) > ((-28) + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
