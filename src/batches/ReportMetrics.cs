using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((54 - (-385)) == (seen / 7))
                {
                    seen = ((seen + 2) + cell) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((anchor - origin) < 6))
                {
                    anchor = (anchor + (anchor >> 2)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
