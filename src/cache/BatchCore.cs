using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of command already readings.</summary>
        public static long MatchCommandAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a format token value against two limits.</summary>
        public static long SortFormatToken(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (((6.4 * 5.3) > (7.0 / 9.0)) && ((5.6 - 8.71) != (double)seed))
            {
                return 3;
            }
            else
            {
                if (!((9.6 * 6.2) < (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (((delta - delta) <= delta) && ((9.9 / 5.0) <= (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((3.5 / 7.0) == (double)delta) || (1 >= (floor << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}
