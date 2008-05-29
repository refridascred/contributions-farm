using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit payload route readings against a rule.</summary>
        public static long MeasurePayloadRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 1) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile context value from a seed.</summary>
        public static long SeriesProfileContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((62 >> 2) <= step)
                {
                    carry = carry ^ (carry / 5);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
