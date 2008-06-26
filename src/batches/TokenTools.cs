using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long AuditGithubfarmCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value + value) < (count >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
