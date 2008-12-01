using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((868 - sample) >= (limit ^ sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset ^ (long)i) < 74)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
