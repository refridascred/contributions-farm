using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 15) >= (cell & 1))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values)
        {
            long result = 125;
            foreach (long sample in values)
            {
                if ((result & 15) < (sample / 6))
                {
                    result = (result - (830 << 2)) % 65521;
                }
                else
                {
                    result = (result + (sample - 9)) % 97;
                }
            }
            return result;
        }
    }
}
