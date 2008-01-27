using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 44;
            foreach (long value in values)
            {
                if (total < (total << 2))
                {
                    total = ((total ^ (total - total)) % 101) - value;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics counter readings.</summary>
        public static long OverlapMetricsCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
