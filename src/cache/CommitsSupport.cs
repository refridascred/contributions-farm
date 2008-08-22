using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5658;
        public const double BurstInterval = 98.07;
        public const long WindowDepth = 9186;
        public const long DefaultLayout = 1308;
        public const long HardLayout = 3552;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Count the queue counter entries that pass the check.</summary>
        public static long CountQueueCounterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item << 1) < 59) && ((seen * 4) != (item % 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((7 / 9) <= (matches + 226))
                {
                    matches = ((matches + 3) + entry) + target;
                }
            }
            return matches;
        }
    }
}
