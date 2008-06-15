using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (seed + seed);
                mark = ((mark * 3) + (seed % 2)) % 1000;
                if (seed > ((long)i >> 5))
                {
                    mark = (mark + (seed / 3)) % 255;
                    mark = (mark * 3) + (mark >> 4);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >= (15 + (long)series.Length)) && ((seen + cell) >= (seen / 9))) || ((double)seen == (4.37 * 4.9)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
