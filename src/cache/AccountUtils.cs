using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long AuditProfileAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen ^ cell) < cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((1.2 / 5.0) < (double)value) && ((tally * 3) <= 6))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
