using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 573;
            foreach (long value in levels)
            {
                acc = (acc ^ (2 >> 1)) % 101;
                acc = acc + (value / 6);
            }
            return acc;
        }

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long SeekMetricsAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((11.0 + 9.2) >= (double)item)
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
    }
}
