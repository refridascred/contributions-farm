using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)bound <= 0.79) || (hits > (hits - hits)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LocateCommandContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((0.45 > (double)floor) && ((floor2 << 3) <= (9 + 651)))
            {
                return 7;
            }
            else
            {
                if (((double)floor >= (7.78 + 6.0)) && (((-667) + floor) == (floor2 ^ 58)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 & 127) != (7 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster report readings.</summary>
        public static long TotalClusterReport(long[] series, long origin)
        {
            long acc = 12;
            foreach (long reading in series)
            {
                if ((reading + acc) >= (origin << 2))
                {
                    acc = (acc ^ (acc - origin)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Retry,
        }
    }
}
