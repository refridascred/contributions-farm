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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 4105;
        public const long BaseWidth = 6195;
        public const long CacheBudget = 1403;
        public const double CacheChecks = 9.62;
        public const long CacheScore = 9950;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

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

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Retry,
            Queued,
            Closed,
            Ready,
        }
    }
}
