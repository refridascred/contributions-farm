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

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool GuardContributiGraphRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
