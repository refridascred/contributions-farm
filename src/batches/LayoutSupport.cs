using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "stable-edge";
        public const double MaxQueue = 11.83;
        public const long IdleQueue = 9675;
        public const long RetryQueue = 2971;
        public const long CacheInterval = 5574;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6282;
        public const long StepCluster = 774;
        public const long IdleCluster = 3774;

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] series)
        {
            long anchor = 198;
            foreach (long cell in series)
            {
                anchor = (anchor - cell) % 1000;
            }
            if (anchor < 488)
            {
                anchor = anchor + (35 << 2);
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)limit <= 3.4))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
