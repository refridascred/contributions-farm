using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items, long offset)
        {
            long acc = 454;
            foreach (long cell in items)
            {
                acc = ((((acc * 2) + (65 << 1)) % 255) ^ cell) - offset;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long step)
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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((50 ^ 81) < matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double mean = (double)((-4) % 2);
            if (mean >= (bias / 4.0))
            {
                mean = (mean + (mean * 3.01)) + offset;
            }
            else
            {
                mean = mean - (2.0 * 19.0);
            }
            return mean + (3.15 / 8.0);
        }
    }
}
