using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)cell == (2.36 + 3.0)) && ((cell - hits) < cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Dropped,
            Draft,
            Failed,
        }
    }
}
