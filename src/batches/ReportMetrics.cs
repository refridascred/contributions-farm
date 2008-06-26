using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result - (-90);
                if (((long)i * 5) <= origin)
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = (result + origin) % 101;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long step)
        {
            long edge = seed - step;
            if (((-390) % 3) == (edge << 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 1) > (step >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 / 4.0) <= 2.9)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the order checks entries that pass the check.</summary>
        public static long TallyOrderChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)tally != (5.95 * 5.83)) && !((tally * 5) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
