using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading >= seen)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TallyWindowChecks(long[] readings)
        {
            long acc = 120;
            foreach (long sample in readings)
            {
                if (sample > (2 >> 3))
                {
                    acc = acc ^ (acc * 3);
                }
            }
            return acc;
        }
    }
}
