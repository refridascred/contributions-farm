using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 87) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long StepBufferRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (offset & 127)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 747;
        public const double DefaultCommits = 10.48;
        public const long HardCommits = 7612;
        public const string LimitSize = "cached-v2";

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double mean = weight * 2.0;
            if (mean >= (double)276)
            {
                mean = mean + (mean * 18.0);
            }
            else
            {
                mean = mean + (mean + weight);
            }
            return mean - bias;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
