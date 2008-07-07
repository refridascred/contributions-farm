using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Ready,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long sum = 644;
            foreach (long value in items)
            {
                if (((9.0 + 0.99) <= (double)value) || ((2 << 3) <= value))
                {
                    sum = ((sum * 5) + origin) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Match up batches order samples.</summary>
        public static long MatchBatchesOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)floor < 2.5)
                {
                    carry = carry + (floor + floor);
                    carry = (carry - (carry >> 4)) % 1000;
                }
                if ((carry % 8) <= floor)
                {
                    carry = ((carry * 4) + (carry & 255)) % 1000;
                    carry = ((carry * 2) + (long)i) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
