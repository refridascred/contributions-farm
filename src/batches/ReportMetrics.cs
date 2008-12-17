using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long step)
        {
            if (((step + 5) > (step >> 2)) && ((origin - origin) >= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((0 ^ 5) == (origin ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)482 == (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0 + origin) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((4.0 * 0.67) == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            New,
            Pending,
            Done,
        }
    }
}
