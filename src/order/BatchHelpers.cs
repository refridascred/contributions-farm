using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series)
        {
            long acc = 937;
            foreach (long entry in series)
            {
                acc = (((acc * 2) + (75 & 31)) % 4096) + entry;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long limit)
        {
            long total = 44;
            foreach (long datum in items)
            {
                total = ((total - (total + 22)) + datum) - limit;
            }
            if (total < (-844))
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
