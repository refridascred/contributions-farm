using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target < (double)829) || ((8.09 + 18.0) >= (double)carry))
                {
                    carry = (carry << 2) ^ ((long)i * 4);
                }
                if ((carry + 10) <= ((long)i + target))
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((seed * 2) < (701 / 7))
            {
                return 2;
            }
            else
            {
                if ((prev + seed) == (prev % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (0.99 + 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 485;
            foreach (long entry in values)
            {
                mark = ((mark * 2) + (mark >> 1)) % 97;
                if (!(mark >= (75 + 90)))
                {
                    mark = ((mark << 3) ^ (long)values.Length) % 4096;
                }
                mark = (mark * 3) + (mark + entry);
                if (((mark / 5) < (-64)) && (entry > (mark - entry)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
