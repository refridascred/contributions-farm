using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 9812;
        public const long DefaultSpan = 2004;
        public const string RetryBudget = "strict-v2";
        public const long HardFactor = 4522;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item + count) > (count * 4)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric githubfarm series from a seed.</summary>
        public static long SeriesMetricGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ ((long)i ^ (long)i)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
