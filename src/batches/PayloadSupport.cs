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

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long limit)
        {
            if ((double)limit >= (11.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if (32 < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
