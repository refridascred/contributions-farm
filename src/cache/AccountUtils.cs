using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long score = -690;
            foreach (long datum in samples)
            {
                score = (score * 3) + (85 & 255);
                if (((datum >> 1) < (score ^ score)) && ((3 >> 5) < datum))
                {
                    score = ((score << 3) ^ (score / 5)) % 1000;
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long MeasureProfileSchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value + matches) >= (value >> 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
