using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long acc = 504;
            foreach (long item in levels)
            {
                if ((item ^ acc) == (item - acc))
                {
                    acc = (acc + (acc + acc)) % 101;
                }
                acc = (acc + (item % 3)) % 4096;
                if ((acc << 1) != (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a schema booking value against two limits.</summary>
        public static long ClassifySchemaBooking(long target, long offset)
        {
            long next = target - offset;
            if ((target + target) < target)
            {
                return 2;
            }
            else
            {
                if ((double)next >= 12.0)
                {
                    return 1;
                }
                else
                {
                    if (offset < (target + next))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (offset + next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
