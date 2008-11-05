using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 3878;
        public const long IdleBudget = 3275;
        public const double BurstContext = 46.49;
        public const long WindowTimeout = 8010;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (3.0 / 4.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Validate layout route readings against a bound.</summary>
        public static bool ValidateLayoutRouteLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session context entries.</summary>
        public static long DigestSessionContext(long[] samples)
        {
            long carry = -9;
            foreach (long value in samples)
            {
                carry = ((carry * 3) + value) % 1000;
                carry = (carry << 3) ^ (value & 127);
            }
            return carry % 1000;
        }
    }
}
