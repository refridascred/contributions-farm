using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order farm readings against a rule.</summary>
        public static long AuditOrderFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((5.2 / 4.0) >= (double)cell) && ((matches - 2) < cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
