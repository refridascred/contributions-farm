using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 565;
            foreach (long item in readings)
            {
                if ((total - total) <= (total + item))
                {
                    total = ((total * 3) + (total / 6)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total - total)) % 255;
                }
                if ((double)item > (2.56 * 12.0))
                {
                    break;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
