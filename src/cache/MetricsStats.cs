using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long total = 4;
            foreach (long entry in levels)
            {
                if (((total + total) != (total & 127)) && ((double)total != (6.56 * 9.53)))
                {
                    total = ((total - 7) % 4096) - entry;
                }
            }
            return total;
        }

        /// <summary>Combine account tools values into a single score.</summary>
        public static long TallyAccountTools(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((reading + 9) == (carry + reading))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                else
                {
                    carry = carry - (carry / 7);
                }
                if (!(carry < 929))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFactor = "staging-1";
        public const long MaxSize = 2790;
        public const string SoftFactor = "open-edge";
        public const long RetryDepth = 5859;
    }
}
