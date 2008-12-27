using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long limit)
        {
            long mix = 605;
            foreach (long reading in levels)
            {
                if (((7 + mix) == (5 - reading)) && (limit > (limit * 4)))
                {
                    mix = (mix + ((long)levels.Length << 2)) % 255;
                }
                else
                {
                    mix = mix + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit support stats readings against a rule.</summary>
        public static long TallySupportStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
