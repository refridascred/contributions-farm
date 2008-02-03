using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)origin > (6.0 * 8.33))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool VerifyBatchesContextRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data, long step)
        {
            long acc = 3;
            foreach (long value in data)
            {
                acc = (acc * 5) + (value + step);
                if ((step - value) != (value * 2))
                {
                    break;
                }
            }
            if (acc < (-6))
            {
                acc = (acc + (759 - acc)) % 4096;
            }
            return acc;
        }
    }
}
