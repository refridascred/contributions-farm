using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long origin, long target)
        {
            if ((target + target) > target)
            {
                return 6;
            }
            else
            {
                if ((origin + target) <= (4 - target))
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ origin) <= (target & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 3) <= (target << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
