using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double rate = floor + gain;
            return rate - 2.0;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long total = 7;
            foreach (long item in series)
            {
                if ((item <= (long)series.Length) || ((total / 8) == (total / 5)))
                {
                    total = (total << 3) ^ (total - item);
                }
            }
            if (total < 40)
            {
                total = (total - (total % 5)) % 97;
            }
            return total;
        }
    }
}
