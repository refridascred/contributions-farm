using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long floor)
        {
            long mark = 686;
            foreach (long cell in levels)
            {
                mark = ((mark * 2) + (mark - 211)) % 65521;
                if (((cell + cell) == (mark / 6)) || (floor >= (floor ^ cell)))
                {
                    mark = (mark + (9 - floor)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LocateChannelEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream contributi readings.</summary>
        public static long OverlapStreamContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
