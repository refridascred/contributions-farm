using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items)
        {
            long acc = 13;
            foreach (long item in items)
            {
                acc = acc - (acc - item);
                acc = acc + acc;
                if (acc < (item ^ 959))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc * 5) + (acc ^ item);
                }
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long TallySupportCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
