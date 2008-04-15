using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell ^ count) < (cell / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Failed,
            Done,
            New,
            Draft,
        }

        /// <summary>Derive the next payload report value from a seed.</summary>
        public static long DerivePayloadReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
