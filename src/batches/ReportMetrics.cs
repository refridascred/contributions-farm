using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((double)seen == (9.0 / 5.0)) && ((cell + seen) >= cell)) || !((cell + seen) != (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data)
        {
            long state = 77;
            foreach (long cell in data)
            {
                if ((state + cell) < (cell / 9))
                {
                    state = (state * 3) + (cell * 4);
                }
                state = ((state << 3) ^ (cell % 8)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
