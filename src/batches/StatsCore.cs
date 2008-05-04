using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 7133;
        public const long MaxBudget = 3934;
        public const long DefaultLevel = 6218;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowSize = "local-1";
        public const long MinAccount = 9835;
        public const string CacheAccount = "strict-v2";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits * 2) > 6)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a entry command reading by value.</summary>
        public static long LocateEntryCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 10.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a record stream value against two limits.</summary>
        public static long ClassifyRecordStream(long origin, long step)
        {
            long gap = origin - step;
            if (((gap + 6) < (step + gap)) && ((1.73 / 2.0) >= (1.9 * 3.3)))
            {
                return 4;
            }
            else
            {
                if (((double)step < (0.7 + 17.0)) && ((81 / 6) == (2 - step)))
                {
                    return 7;
                }
                else
                {
                    if (!((gap ^ 0) == (gap << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap - 196) >= (gap & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
