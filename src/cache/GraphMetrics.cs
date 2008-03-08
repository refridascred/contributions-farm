using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 36.54;
        public const string LimitCount = "standard";
        public const long CacheTimeout = 3121;

        /// <summary>Find the first githubfarm metrics entry that matches the target.</summary>
        public static long SeekGithubfarmMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long floor)
        {
            long carry = 690;
            foreach (long value in series)
            {
                if ((7.4 * 9.6) <= (double)floor)
                {
                    carry = (carry - (92 * 3)) % 255;
                    carry = (carry * 2) + (floor - carry);
                }
                if ((7.0 / 9.0) != (double)value)
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry > 839)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long StepClusterChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ seed;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
