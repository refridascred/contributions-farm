using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum / 7) < target) && (((datum % 100) <= (datum & 7)) || (count <= (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count commits context pairs that satisfy a relation.</summary>
        public static long CompareCommitsContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= bias)
            {
                bias2 = bias2 - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + ratio) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= 94)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
