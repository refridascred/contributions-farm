using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels, long offset)
        {
            long total = 204;
            foreach (long sample in levels)
            {
                if (!((3.57 - 1.0) >= (double)sample))
                {
                    break;
                }
                total = ((total - (total / 3)) % 101) - offset;
                if (sample >= (total * 2))
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = (total ^ (total << 1)) % 101;
            }
            return total;
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= ((-55) & 127))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LookupStreamBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
