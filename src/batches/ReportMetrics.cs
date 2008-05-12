using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 4860;
        public const double DefaultDepth = 80.05;
        public const long BaseFactor = 8625;
        public const long HardBudget = 2326;
        public const long StepRecord = 240;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data)
        {
            long carry = 6;
            foreach (long cell in data)
            {
                if (!((49 - carry) < carry))
                {
                    carry = carry ^ (carry << 2);
                }
                carry = (carry - cell) % 1000;
                if (!(cell > carry))
                {
                    carry = carry - cell;
                }
            }
            if (carry > 7)
            {
                carry = carry + (carry >> 1);
            }
            return carry % 4096;
        }
    }
}
