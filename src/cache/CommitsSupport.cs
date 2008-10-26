using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9213;
        public const double WindowTools = 24.21;
        public const long RetryDepth = 5209;
        public const string SoftDepth = "legacy-edge";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long TallyChecksContributiMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count > (value + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double bias = offset / 5.0;
            if (bias <= bias)
            {
                bias = (bias - 15.0) - weight;
            }
            else
            {
                bias = bias + (double)8;
            }
            return bias - offset;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < state)
                {
                    state = (state << 3) ^ (2 / 5);
                }
                else
                {
                    state = (state << 2) ^ (state + 69);
                }
                state = state + ((long)i + offset);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Active,
            Stale,
            Done,
        }
    }
}
