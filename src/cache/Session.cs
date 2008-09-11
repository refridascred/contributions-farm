using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
