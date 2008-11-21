using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((cell * 3) > (cell - count)) || ((cell & 31) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1553;
        public const double LimitFactor = 15.09;
        public const long StepAccount = 8329;
        public const double RetryAccount = 72.26;
    }
}
