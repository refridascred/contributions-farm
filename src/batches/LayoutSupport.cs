using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 32;
            foreach (long value in readings)
            {
                if (value <= (carry + carry))
                {
                    carry = (carry + (value - carry)) % 255;
                }
            }
            if (carry > 956)
            {
                carry = (carry * 2) + (carry + 699);
            }
            return carry;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Stale,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1217;
        public const long CacheLayout = 430;
        public const string IdleDepth = "open-v2";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((item + limit) > 71))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
