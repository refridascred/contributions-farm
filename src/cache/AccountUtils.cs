using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen >= (3.8 - 5.62))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
