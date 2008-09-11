using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxWidth = "open-1";
        public const long WindowTimeout = 7826;
        public const double StepChecks = 67.47;
        public const string RetrySize = "primary";
        public const long CacheWidth = 3528;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item - bound) != ((long)values.Length - 529)) || (((709 << 2) > (bound & 1)) && ((85 / 2) >= (seen << 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (target + sum)) % 4096;
                if (target >= (target & 31))
                {
                    sum = (sum << 3) ^ (target / 9);
                    sum = (sum ^ 710) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
