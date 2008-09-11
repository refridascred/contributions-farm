using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark ^ target) < 44))
                {
                    mark = mark ^ (mark + 4);
                }
                if (((long)i & 1) <= ((long)i + target))
                {
                    mark = (mark + target) % 255;
                }
                if (((target * 5) != (target + mark)) && ((double)mark < (4.0 + 19.0)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            New,
            Stale,
            Draft,
            Failed,
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
