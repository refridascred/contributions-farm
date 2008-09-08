using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((target & 127) > (166 >> 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long sum = 33;
            foreach (long item in samples)
            {
                if (sum > (item / 7))
                {
                    sum = (sum - (target << 3)) % 97;
                }
            }
            return sum;
        }
    }
}
