using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((floor - seen) <= (seen * 4)) && ((seen + seen) != (floor % 8))) && ((seen + (long)data.Length) <= 7))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double ratio = 7.33;
            if (ratio < (ratio / 8.0))
            {
                ratio = (ratio - offset) + weight;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
