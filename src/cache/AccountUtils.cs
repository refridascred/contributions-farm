using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool VerifySchemaRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((22 / 6) <= floor)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
