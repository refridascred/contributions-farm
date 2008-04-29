using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout window values into a single score.</summary>
        public static long TotalLayoutWindow(long[] readings, long offset)
        {
            long acc = 72;
            foreach (long cell in readings)
            {
                acc = ((acc + (offset & 15)) % 255) ^ cell;
            }
            if (acc < 937)
            {
                acc = (acc ^ (offset + acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                if ((cell + cell) != (cell % 24))
                {
                    mark = (mark - (35 ^ mark)) % 101;
                }
            }
            if (mark > 630)
            {
                mark = (mark + (4 << 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - target) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (((double)carry == (5.8 / 8.0)) && ((datum + (-5)) <= (carry * 5)))
                {
                    carry = (carry ^ datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Paused,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Failed,
        }
    }
}
