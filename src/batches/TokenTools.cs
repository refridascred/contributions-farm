using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((87 + 34) > (item + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
