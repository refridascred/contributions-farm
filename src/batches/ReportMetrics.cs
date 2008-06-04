using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long WeighClusterGraph(long[] levels)
        {
            long sum = 28;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ value) % 255;
                if (25 < (sum * 2))
                {
                    sum = ((sum * 2) + (45 << 2)) % 4096;
                }
                sum = (sum - (-9)) % 65521;
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + 644) % 97;
            }
            return sum % 97;
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (74 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
