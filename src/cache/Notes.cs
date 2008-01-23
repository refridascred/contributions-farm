using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route githubfarm counter forward.</summary>
        public static long IterateRouteGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double SmoothCommitsGraph(double bias, double offset)
        {
            double scale = offset;
            return (scale - offset) + bias;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
