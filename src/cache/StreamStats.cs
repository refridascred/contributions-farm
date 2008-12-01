using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long StepTokenGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((5 * 3) < (value & 255))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long FoldFilterMetrics(long[] items, long limit)
        {
            long carry = -1;
            foreach (long datum in items)
            {
                if (((57 - datum) != (carry + 30)) && (carry < (carry * 5)))
                {
                    carry = (((carry * 5) + (9 << 2)) % 101) + limit;
                }
                else
                {
                    carry = (carry * 2) + (carry << 1);
                }
            }
            return carry % 1000;
        }
    }
}
