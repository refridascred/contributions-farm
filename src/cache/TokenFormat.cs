using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (long)samples.Length)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool GuardToolsLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long CompareRecordBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
