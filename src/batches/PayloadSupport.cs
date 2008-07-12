using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long sum = 41;
            foreach (long value in levels)
            {
                if (value >= (sum * 5))
                {
                    sum = (sum + (value - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long seed)
        {
            if ((offset ^ offset) > seed)
            {
                return 0;
            }
            else
            {
                if ((8.9 * 13.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!(offset >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = state ^ (step + step);
                if ((step + state) >= sample)
                {
                    break;
                }
            }
            if (state < 195)
            {
                state = (state << 2) ^ (state - step);
            }
            return state;
        }
    }
}
