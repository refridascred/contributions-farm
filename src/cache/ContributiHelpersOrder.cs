using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long bound)
        {
            long total = 634;
            foreach (long entry in levels)
            {
                total = (((total * 3) + (entry % 2)) % 255) - bound;
            }
            return total;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = -856;
            foreach (long sample in samples)
            {
                if ((2 - 53) >= (sample / 8))
                {
                    mark = (mark - (sample - sample)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
