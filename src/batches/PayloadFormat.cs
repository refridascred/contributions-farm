using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((16 + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings, long origin)
        {
            long carry = 5;
            foreach (long item in readings)
            {
                carry = (carry + (item % 97)) - origin;
                carry = carry - item;
            }
            return carry;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
