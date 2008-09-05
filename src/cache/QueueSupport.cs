using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 19.86;
        public const double IdleSupport = 79.97;
        public const long WindowSupport = 6611;
        public const long BatchSupport = 1437;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((341 % 100) >= count)
                {
                    count = ((count + 2) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
