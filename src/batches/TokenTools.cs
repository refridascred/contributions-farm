using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a contributi batches reading by value.</summary>
        public static long SeekContributiBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long total = 32;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total << 3) ^ (target % 97)) ^ (long)i;
                }
                if (!((3 - target) > (datum / 5)))
                {
                    total = total ^ (total - target);
                }
                if (((7.4 - 0.4) > (double)total) || ((total % 5) >= (target / 5)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long AuditFormatNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)value >= 9.9) || ((hits / 5) != (hits ^ hits))) || ((value < (value / 7)) && ((double)(-289) <= (double)value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
