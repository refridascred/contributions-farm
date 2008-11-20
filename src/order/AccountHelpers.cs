using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long acc = 419;
            foreach (long cell in data)
            {
                if (cell > (7 * 3))
                {
                    acc = (acc + (cell - acc)) % 97;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc << 2) ^ (acc + 92)) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7647;
        public const double BaseWidth = 46.41;
        public const double LimitWindow = 62.61;
        public const long BaseSpan = 6114;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 5970;
        public const double DefaultStats = 17.33;
        public const string MinDepth = "alpha-edge";
        public const long DefaultWidth = 6633;
        public const string SoftStats = "primary-v2";

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5697;
        public const long BaseInterval = 7397;
        public const string BurstBudget = "fallback-1";
        public const long BatchRecord = 3391;
        public const long HardRecord = 6031;
    }
}
