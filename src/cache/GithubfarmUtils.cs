using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc ^ (20 - acc)) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((8 % 64) < (datum << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchTimeout = "fallback-1";
        public const double IdleInterval = 74.04;
        public const string IdleRoute = "stable";
    }
}
