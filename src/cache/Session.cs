using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long MatchClusterChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every layout checks entry stays within the limit.</summary>
        public static bool GuardLayoutChecksBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double floor)
        {
            double ratio = (double)((-308) >> 4);
            if (ratio <= (double)(-4))
            {
                ratio = (ratio - (17.0 / 9.0)) - scale;
            }
            else
            {
                ratio = ratio - (8.3 * 1.5);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 2.0) - (double)(long)i;
            }
            return ratio - (floor * 1.06);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item >= hits)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
