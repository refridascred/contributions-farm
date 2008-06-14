using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long limit)
        {
            if ((limit % 7) == (46 ^ step))
            {
                return 4;
            }
            else
            {
                if (step < (step ^ 47))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 % 5) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account already entry stays within the limit.</summary>
        public static bool ValidateAccountAlreadyLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
