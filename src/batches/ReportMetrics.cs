using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long seed)
        {
            long cur = step + seed;
            if (!((705 - cur) > seed))
            {
                return 1;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Paused,
            Ready,
            Pending,
        }
    }
}
