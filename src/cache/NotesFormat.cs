using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long step)
        {
            long acc = 756;
            foreach (long cell in series)
            {
                if ((double)cell <= (0.1 / 9.0))
                {
                    acc = acc + (cell - step);
                }
                else
                {
                    acc = ((acc * 5) + (acc % 24)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi buffer sample.</summary>
        public static long LookupContributiBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route order input into a small class.</summary>
        public static long SortRouteOrder(long floor, long target)
        {
            long gap = floor + target;
            if (!((target * 5) < floor))
            {
                return 1;
            }
            else
            {
                if ((gap << 2) > floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
