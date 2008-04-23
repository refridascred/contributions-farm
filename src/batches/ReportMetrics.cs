using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin - origin) != ((long)i << 2)))
                {
                    anchor = (anchor ^ (origin + anchor)) % 4096;
                }
                if (anchor < (anchor % 2))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (origin ^ anchor)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (4.0 * 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
