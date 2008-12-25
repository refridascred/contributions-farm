using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile graph values into a single score.</summary>
        public static long TotalProfileGraph(long[] readings)
        {
            long carry = 987;
            foreach (long sample in readings)
            {
                if (carry > (sample + 2))
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
                if (((double)sample <= (3.2 / 4.0)) && (sample <= ((-551) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a format commits sample.</summary>
        public static long SeekFormatCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats record samples.</summary>
        public static long OverlapStatsRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
