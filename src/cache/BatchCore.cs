using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long MeasurePayloadStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 2) == (value - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell % 8) > (limit - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
