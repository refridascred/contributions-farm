using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first command stream entry that matches the target.</summary>
        public static long LocateCommandStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7935;
        public const string IdleLayout = "strict-v2";
        public const string SoftSize = "local-edge";

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long target)
        {
            if ((target < (target + target)) && ((step >> 3) >= (92 + 559)))
            {
                return 8;
            }
            else
            {
                if ((777 + target) >= step)
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
