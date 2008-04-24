using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 4299;
        public const long BatchInterval = 4884;
        public const double BaseProfile = 57.25;
        public const long BatchCount = 4364;
        public const long LimitBudget = 7057;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                bool ok = offset >= (sum / 5);
                if (!((sum > (sum * 3)) || ok))
                {
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
