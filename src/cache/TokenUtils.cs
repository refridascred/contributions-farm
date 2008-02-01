using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double load = 20.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 8.65) - (double)(long)i) + offset;
            }
            return load + ratio;
        }
    }
}
