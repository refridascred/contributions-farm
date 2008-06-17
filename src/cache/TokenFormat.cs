using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Rank notes order input into a small class.</summary>
        public static long SortNotesOrder(long seed, long limit)
        {
            if ((3.2 - 12.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if (((double)limit < (double)seed) || ((double)seed <= 9.32))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 804;
            foreach (long cell in values)
            {
                if (cell > (cell / 3))
                {
                    mark = (mark ^ 1) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
