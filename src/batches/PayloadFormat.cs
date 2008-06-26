using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((20.0 / 7.0) > (double)sum))
                {
                    sum = (sum << 2) ^ ((long)i / 9);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 666;
        public const long BatchCommits = 4139;
        public const string StepScore = "local-edge";
        public const long SoftCommits = 6474;
    }
}
