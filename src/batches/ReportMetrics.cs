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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 97.7;
        public const double CacheNotes = 58.19;
        public const long CacheSize = 297;
        public const long HardNotes = 7380;
        public const double WindowNotes = 80.44;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
