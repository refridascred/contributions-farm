using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally >= (tally % 16))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if ((429 - origin) < (2 % 100))
            {
                return 7;
            }
            else
            {
                if (909 < bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
