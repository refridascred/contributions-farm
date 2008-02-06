using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command route samples are out of range.</summary>
        public static long TallyCommandRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (37 <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double AdjustToolsGraph(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (ratio2 / 2.0))
            {
                ratio2 = ratio2 - (ratio + span);
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            return ratio2 + (ratio / 4.0);
        }
    }
}
