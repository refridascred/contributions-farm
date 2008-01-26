using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9179;
        public const long BatchFormat = 7719;
        public const long WindowCount = 1949;
        public const double HardFormat = 19.14;
        public const long MaxBudget = 452;

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long TotalStatsProfile(long[] series, long target)
        {
            long mark = 59;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 3) + mark) % 1000) ^ (long)i;
                }
                if ((cell >> 1) <= mark)
                {
                    mark = ((mark * 2) + (cell & 31)) % 65521;
                }
                if (1.86 < (double)cell)
                {
                    break;
                }
            }
            if (mark < 28)
            {
                mark = (mark + (target % 64)) % 65521;
            }
            return mark % 65521;
        }
    }
}
