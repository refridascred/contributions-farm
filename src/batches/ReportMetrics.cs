using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count metric window pairs that satisfy a relation.</summary>
        public static long MatchMetricWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long carry = 82;
            foreach (long cell in series)
            {
                carry = (carry * 5) + (carry * 3);
                if ((double)step < (1.8 - 6.7))
                {
                    carry = ((carry * 2) + (cell / 3)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
