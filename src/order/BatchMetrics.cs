using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)step > (7.4 * 8.2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 41.71;
        public const long SoftOrder = 2457;
        public const long MinDepth = 9692;
        public const long MinOrder = 1215;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double weight = 9.5;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - scale;
            }
            return weight - weight;
        }
    }
}
