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

        /// <summary>Fold a list of filter window readings.</summary>
        public static long WeighFilterWindow(long[] readings, long seed)
        {
            long mark = 74;
            foreach (long reading in readings)
            {
                if (!((mark - reading) < 1))
                {
                    mark = (mark << 2) ^ mark;
                }
                if (seed <= ((long)readings.Length * 5))
                {
                    break;
                }
            }
            if (mark < 53)
            {
                mark = mark + mark;
            }
            return mark;
        }
    }
}
