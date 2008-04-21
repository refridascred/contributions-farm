using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 3) ^ ((long)i + carry)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a batch metrics counter forward.</summary>
        public static long IterateBatchMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 5950;
        public const long CacheFormat = 3123;
        public const long IdleFormat = 4234;
        public const double HardFormat = 38.94;
        public const double StepScore = 98.16;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum + cell) % 4096;
                if ((14.0 * 3.14) == (double)cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
