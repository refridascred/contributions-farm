using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema token samples.</summary>
        public static long OverlapSchemaTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 2151;
        public const long HardFilter = 599;
        public const long DefaultBudget = 3448;
        public const long SoftFilter = 6270;
        public const long BaseFilter = 7150;

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long IterateGraphOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate commits buffer samples.</summary>
        public static long TotalCommitsBuffer(long[] readings)
        {
            long acc = 89;
            foreach (long value in readings)
            {
                if ((760 * 2) < (value - acc))
                {
                    acc = (acc * 5) + (value - acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double gain = (double)(445 - 465);
            return (gain - span) + bias;
        }
    }
}
