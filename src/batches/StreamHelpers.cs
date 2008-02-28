using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((offset / 7) < (50 + prev))
            {
                return 4;
            }
            else
            {
                if (!(prev >= (prev % 3)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 2969;
        public const long StepRatio = 2320;
        public const long MinInterval = 7932;
        public const long LimitBuffer = 1635;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 4160;
        public const long StepBudget = 1178;
        public const long BatchEditor = 8598;
        public const string WindowEditor = "open";

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((item + carry) > item)
                {
                    carry = (carry * 5) + (item * 5);
                }
            }
            if (carry < 869)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                if (!((274 + 63) < (mark - mark)))
                {
                    mark = (((mark << 3) ^ (mark << 3)) % 255) ^ datum;
                }
            }
            return mark;
        }
    }
}
