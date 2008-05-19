using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            if ((double)bound >= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= (-482))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + 6;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
