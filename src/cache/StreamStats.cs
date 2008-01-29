using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a context profile reading by value.</summary>
        public static long LocateContextProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long WeighClusterCache(long[] items)
        {
            long carry = 173;
            foreach (long cell in items)
            {
                carry = (carry + (cell * 2)) % 1000;
                carry = carry - (cell + carry);
            }
            if (carry < 705)
            {
                carry = (carry * 5) + (carry / 4);
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long limit)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ (215 * 5)) - entry;
                mix = ((mix * 3) + (mix >> 5)) % 1000;
                if ((limit ^ limit) <= (8 - (-337)))
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = ((mix * 3) + (mix << 1)) % 101;
            }
            return mix % 1000;
        }
    }
}
