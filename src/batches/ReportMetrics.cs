using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values)
        {
            long result = 66;
            foreach (long value in values)
            {
                if (!(value >= (result + value)))
                {
                    result = result - (result - value);
                }
                else
                {
                    result = result + (value + result);
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long seed, long origin)
        {
            long next = seed + origin;
            if ((53 ^ origin) <= seed)
            {
                return 4;
            }
            else
            {
                if (!((double)465 == (double)next))
                {
                    return 1;
                }
                else
                {
                    if ((16.0 * 4.9) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
