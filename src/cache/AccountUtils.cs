using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 30;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (anchor % 8)) % 101) - (long)i;
                    anchor = anchor + anchor;
                }
                if ((anchor < (anchor & 63)) || ((reading + reading) > (reading / 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = (anchor * 3) + reading;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor + ((long)levels.Length - anchor);
            }
            return anchor;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
