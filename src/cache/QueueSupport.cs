using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor + ((long)i2 + origin)) % 97;
                }
                if ((184 - anchor) != (origin + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                    anchor = anchor - origin;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long AuditTokenGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((3.02 / 9.0) != (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
