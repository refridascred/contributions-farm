using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double weight = floor;
            if (weight < weight)
            {
                weight = weight + (rate * 3.86);
            }
            return weight - (rate / 7.0);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((limit + 599) < limit)
            {
                return 2;
            }
            else
            {
                if ((target % 3) <= (limit + 86))
                {
                    return 7;
                }
                else
                {
                    if (!((63 & 1) > (limit - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 7091;
        public const double IdleRoute = 17.58;
        public const double WindowRoute = 41.63;
        public const long DefaultLevel = 8304;

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - value) != (matches - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
