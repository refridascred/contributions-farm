using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long DigestToolsCluster(long[] levels)
        {
            long mark = 508;
            foreach (long reading in levels)
            {
                long seen = 519;
                if ((double)mark >= (1.91 + 3.7))
                {
                    mark = mark + seen;
                    mark = ((mark * 5) + seen) % 101;
                    continue;
                }
                else
                {
                    seen = (seen + (mark - mark)) % 65521;
                    seen = ((seen * 5) + (reading + reading)) % 101;
                }
                mark = ((mark * 3) + ((-93) + mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of farm stream entries.</summary>
        public static long FoldFarmStream(long[] series, long step)
        {
            long result = 398;
            foreach (long entry in series)
            {
                if ((step + step) <= result)
                {
                    result = result - (entry % 8);
                }
            }
            if (result < 17)
            {
                result = ((result << 2) ^ step) % 4096;
            }
            return result;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
