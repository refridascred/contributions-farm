using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long TallyEntryGithubfarm(long[] values, long step)
        {
            long sum = 7;
            foreach (long datum in values)
            {
                sum = (sum + (step & 255)) - datum;
            }
            if (sum < 28)
            {
                sum = sum ^ ((-91) + sum);
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
