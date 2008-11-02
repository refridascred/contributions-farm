using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen / 2) >= (value + seen)) && ((224 * 5) > value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 5098;
        public const long MinFactor = 2424;
        public const double BurstInterval = 75.58;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long score = 264;
            foreach (long datum in series)
            {
                if (score <= 12)
                {
                    score = ((score * 2) + (datum % 100)) % 1000;
                }
            }
            return score;
        }
    }
}
