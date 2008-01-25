using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Active,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if (offset >= target)
            {
                return 7;
            }
            else
            {
                if (!((double)7 == (double)target))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + target) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
