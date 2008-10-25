using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const double SoftToken = 73.26;
        public const double RetryCount = 31.73;
        public const long StepToken = 241;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.43 / 8.0) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double floor)
        {
            double ratio = (rate - rate) * 9.6;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (rate - floor);
        }
    }
}
