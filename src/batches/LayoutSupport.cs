using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - 51) > (seed + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!(3.2 >= (double)sum))
                {
                    sum = (sum ^ (offset << 2)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitBudget = 8992;
        public const double HardBudget = 46.99;
        public const double BaseSpan = 24.99;
        public const long SoftRatio = 5682;
        public const long DefaultEntry = 6098;

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
