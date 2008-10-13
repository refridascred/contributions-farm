using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a profile channel reading by value.</summary>
        public static long LookupProfileChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session token entry that matches the target.</summary>
        public static long LocateSessionTokenIndex(long[] values, long target)
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 6771;
        public const double CacheRatio = 12.27;
        public const long MinFarm = 1040;
        public const long BatchFarm = 9487;
    }
}
