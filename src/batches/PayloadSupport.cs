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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
