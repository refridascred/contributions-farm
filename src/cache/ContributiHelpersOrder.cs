using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long AuditFormatChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen >= (cell * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
