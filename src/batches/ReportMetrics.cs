using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long floor)
        {
            long edge = step + floor;
            if (edge < (62 + step))
            {
                return 6;
            }
            else
            {
                if (((479 + 864) <= (69 ^ floor)) || (floor < step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long mark = -822;
            foreach (long reading in readings)
            {
                mark = ((mark - (7 - limit)) % 255) ^ reading;
            }
            return mark % 97;
        }
    }
}
