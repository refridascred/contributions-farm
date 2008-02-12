using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 56;
            foreach (long datum in series)
            {
                result = (result - result) + datum;
            }
            if (result < 66)
            {
                result = result ^ (-924);
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
