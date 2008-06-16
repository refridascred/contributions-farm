using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Dropped,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ 26) > (81 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
