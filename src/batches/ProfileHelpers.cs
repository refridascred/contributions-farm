using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item + 486) >= (count + item)) || !((9 + item) > (count / 4)))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 79.77;
        public const string StepCommits = "primary-v2";
        public const long MinCommits = 1303;
        public const long DefaultCommits = 4793;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long score = 70;
            foreach (long item in series)
            {
                if ((((-33) - item) >= (score + score)) && (item >= (score + 87)))
                {
                    score = (score + (item + score)) % 97;
                }
                score = (score ^ (1 + score)) % 101;
                if ((10.0 / 3.0) > (double)item)
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long AuditLayoutEditorMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.22 / 9.0) == (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
