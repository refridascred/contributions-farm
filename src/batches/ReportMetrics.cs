using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.9 * 2.32))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + 36) <= (count ^ 93))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
