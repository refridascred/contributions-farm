using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches >> 3) <= (step - step))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((limit + 41) < matches) && ((matches << 3) > (reading + reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
