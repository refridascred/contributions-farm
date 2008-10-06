using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSpan = 5679;
        public const double IdleDepth = 12.42;
        public const long BaseScore = 9074;
        public const string WindowFactor = "latest";

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3929;
        public const long DefaultOrder = 1543;
        public const string CacheLevel = "standard-v2";
        public const long MaxInterval = 4448;
        public const long LimitDepth = 1846;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a layout window value against two limits.</summary>
        public static long SortLayoutWindow(long bound, long limit)
        {
            if (((bound ^ limit) >= ((-1) - limit)) || ((145 / 9) >= (bound % 8)))
            {
                return 3;
            }
            else
            {
                if ((5.0 / 6.0) <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 4) < (limit ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.0 - 6.41) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
