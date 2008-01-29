using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchTimeout = 1430;
        public const long MaxCount = 4266;
        public const long BatchStats = 1794;
        public const double MinTimeout = 20.72;

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
