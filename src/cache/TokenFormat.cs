using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double span)
        {
            double ratio = 3.4;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - span) + (double)(long)i) + rate;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a order report reading by value.</summary>
        public static long FindOrderReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
