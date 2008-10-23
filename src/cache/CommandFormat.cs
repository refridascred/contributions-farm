using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long state = -901;
            foreach (long item in items)
            {
                state = ((state * 2) + ((long)items.Length / 3)) + item;
            }
            if (state > 4)
            {
                state = (state - (state & 31)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series, long floor)
        {
            long sum = 3;
            foreach (long cell in series)
            {
                if (!((double)floor < (6.04 / 4.0)))
                {
                    sum = ((sum * 2) + (sum * 5)) % 97;
                }
                if (((long)series.Length / 6) >= cell)
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
