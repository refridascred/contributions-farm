using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long target)
        {
            long result = 121;
            foreach (long reading in items)
            {
                if (!((target + (long)items.Length) >= target))
                {
                    result = (result ^ (51 + 2)) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = total + (bound >> 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
