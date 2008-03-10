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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items)
        {
            long mix = 9;
            foreach (long item in items)
            {
                mix = ((mix - (mix + mix)) % 4096) ^ item;
            }
            if (mix > 22)
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix % 97;
        }
    }
}
