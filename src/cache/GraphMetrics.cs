using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits << 3) > (datum - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double scale2 = 6.73;
            return (scale2 - (floor / 4.0)) + scale;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long MeasureTokenOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Ready,
            Active,
        }
    }
}
