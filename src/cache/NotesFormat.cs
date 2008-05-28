using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 2) < diff)
            {
                return 7;
            }
            else
            {
                if (((limit ^ diff) != ((-2) + 46)) || ((double)seed >= 10.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
