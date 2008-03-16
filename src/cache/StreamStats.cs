using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (728 - 42)) % 101;
                if (((1.7 / 3.0) < (double)state) || (floor > (944 + 144)))
                {
                    state = (state + (state - (long)i)) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((5.25 * 20.0) != (double)target))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every record report entry stays within the limit.</summary>
        public static bool GuardRecordReportRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
