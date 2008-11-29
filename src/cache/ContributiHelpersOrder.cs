using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long total = 23;
            foreach (long sample in items)
            {
                if ((total * 5) != (sample - total))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = ((total << 3) ^ total) % 101;
                }
            }
            if (total > 79)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }
    }
}
