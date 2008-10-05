using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step * 2) >= (anchor & 31))
                {
                    anchor = anchor - 422;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3423;
        public const string IdleBudget = "standard-v2";
        public const string LimitSupport = "primary-v2";
        public const long SoftSupport = 5101;
    }
}
