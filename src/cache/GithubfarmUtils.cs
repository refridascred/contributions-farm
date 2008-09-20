using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) + (long)i2;
                    anchor = (anchor - (anchor / 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 177;
            foreach (long entry in series)
            {
                if (((double)entry >= (double)8) || ((double)entry > (4.41 + 8.0)))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Active,
            Pending,
            Closed,
        }
    }
}
