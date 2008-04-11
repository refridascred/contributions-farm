using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long TallyContributiStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((9.86 / 9.0) == (double)cell) || !((cell ^ 70) == (64 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = result + (6 + offset);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4164;
        public const long DefaultGraph = 67;
        public const long IdleFactor = 6072;
        public const double HardGraph = 22.77;
    }
}
