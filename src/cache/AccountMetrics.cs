using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a checks filter value against two limits.</summary>
        public static long SortChecksFilter(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (bound >= (540 << 3))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != (offset - offset)) || ((offset - bound2) < (504 + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound2 == (4.38 - 9.44))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (offset / 5)) || ((bound >> 5) <= (bound2 * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((2.0 / 2.0) != (double)reading) && (((4 >> 2) >= (reading << 2)) || ((matches + matches) <= (matches & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
