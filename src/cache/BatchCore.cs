using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 493;
        public const long BurstBudget = 3508;
        public const long BurstCache = 3120;
        public const long HardInterval = 3216;
        public const double LimitScore = 9.38;

        /// <summary>Look up the position of a contributi record sample.</summary>
        public static long LocateContributiRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double rate = ratio * 9.3;
            if (rate <= ratio)
            {
                rate = (rate + (rate / 3.0)) - floor;
            }
            else
            {
                rate = rate - (double)52;
            }
            return rate + (double)131;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (tally < (item ^ (long)values.Length))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
