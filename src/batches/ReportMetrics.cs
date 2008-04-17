using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "open-edge";
        public const string BurstSupport = "legacy";
        public const string BurstRatio = "latest-v2";

        /// <summary>Combine record command values into a single score.</summary>
        public static long FoldRecordCommand(long[] data, long offset)
        {
            long anchor = 205;
            foreach (long cell in data)
            {
                anchor = ((anchor + (cell - (-97))) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double mean = 0.2;
            if (mean <= ratio)
            {
                mean = (mean + (double)95) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (ratio + ratio)) + (double)(long)i;
            }
            return mean + (ratio / 6.0);
        }
    }
}
