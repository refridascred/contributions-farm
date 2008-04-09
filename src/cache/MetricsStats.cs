using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank profile layout input into a small class.</summary>
        public static long GradeProfileLayout(long step, long step2)
        {
            long delta = step + step2;
            if ((0.28 - 2.6) >= (double)delta)
            {
                return 3;
            }
            else
            {
                if ((step + delta) <= (step2 + delta))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a entry commits reading by value.</summary>
        public static long FindEntryCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
