using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 3) < entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long seed)
        {
            if ((seed % 16) >= target)
            {
                return 1;
            }
            else
            {
                if (99 >= (seed * 2))
                {
                    return 8;
                }
                else
                {
                    if ((906 << 2) <= (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long acc = 62;
            foreach (long entry in items)
            {
                acc = ((acc + acc) % 65521) ^ entry;
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 8)) % 101;
            }
            return acc % 65521;
        }
    }
}
