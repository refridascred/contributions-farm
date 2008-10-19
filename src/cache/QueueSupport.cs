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

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
