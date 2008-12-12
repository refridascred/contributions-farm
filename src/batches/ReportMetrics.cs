using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (93 >= (step + step))
                {
                    total = ((total << 2) ^ 76) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ total) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((12.0 + 2.69) < (double)hits)
                {
                    hits = ((hits + 1) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
