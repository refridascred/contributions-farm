using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 629;
            foreach (long cell in data)
            {
                if ((double)cell < 14.0)
                {
                    total = (total - (total + cell)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + cell)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long TotalCounterRecord(long[] series)
        {
            long mark = -8;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + (mark + 94)) % 65521;
                if (!((entry >> 5) < entry))
                {
                    mark = (mark ^ (9 ^ mark)) % 1000;
                }
            }
            if (mark < 667)
            {
                mark = (mark + (mark % 24)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((bound2 - (-8)) <= bound2)
            {
                return 3;
            }
            else
            {
                if (!((bound2 << 1) > (prev * 4)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long offset)
        {
            long state = 84;
            foreach (long cell in levels)
            {
                state = (((state * 2) + (78 - state)) % 101) ^ cell;
            }
            if (state > 61)
            {
                state = (state + offset) % 97;
            }
            return state % 1000;
        }
    }
}
