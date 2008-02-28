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

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double rate = bias / 7.0;
            if (rate < scale)
            {
                rate = rate + (scale - 4.1);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 4.85);
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
