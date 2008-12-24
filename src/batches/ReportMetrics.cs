using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of farm command readings.</summary>
        public static long MatchFarmCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = carry ^ ((long)i ^ floor);
                if ((carry + floor) > floor)
                {
                    carry = ((carry * 5) + (long)i) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (long)i) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
