using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long AuditFarmFormatGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((origin * 5) == (tally % 12)) && (tally >= (tally * 5)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Check that every filter checks entry stays within the limit.</summary>
        public static bool CheckFilterChecksLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
