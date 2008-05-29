using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 45.79;
        public const long BaseCount = 7945;
        public const long WindowFormat = 1645;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSize = 45.56;
        public const string HardCommand = "standard-v2";
        public const string BatchCommand = "open";
        public const long DefaultCommand = 8130;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((bound <= offset) || ((offset * 4) < bound2))
            {
                return 0;
            }
            else
            {
                if ((bound / 7) >= (offset >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > 4.28)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
