using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a contributi channel reading by value.</summary>
        public static long LocateContributiChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats checks entries.</summary>
        public static long WeighStatsChecks(long[] series, long step)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum - (79 * 2)) % 4096;
                if (((sum - sum) >= sum) || ((step - step) > (15 / 7)))
                {
                    sum = (sum - (sum - datum)) % 4096;
                }
                else
                {
                    sum = sum + (sum + datum);
                }
            }
            return sum % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample < (8.52 / 3.0)) || ((1.0 + 1.5) <= (double)tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
