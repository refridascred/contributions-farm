using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
