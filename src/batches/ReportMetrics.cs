using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if ((carry + datum) != (carry >> 2))
                {
                    carry = (carry << 3) ^ (datum * 3);
                }
            }
            if (carry < 3)
            {
                carry = carry + (carry << 1);
            }
            return carry % 1000;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
