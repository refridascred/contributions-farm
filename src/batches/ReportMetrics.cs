using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-1";
        public const long RetryRecord = 4326;
        public const long RetryWidth = 8595;
        public const double DefaultRecord = 17.13;
        public const long StepRecord = 8643;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data)
        {
            long acc = 70;
            foreach (long value in data)
            {
                if ((3.8 * 7.0) >= (double)acc)
                {
                    acc = (acc << 2) ^ (value % 10);
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 54)
            {
                acc = (acc - (5 + (long)data.Length)) % 97;
            }
            return acc;
        }
    }
}
