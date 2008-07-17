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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long result = 25;
            foreach (long item in levels)
            {
                result = result + (item / 9);
            }
            if (result > 3)
            {
                result = ((result << 3) ^ (result << 1)) % 65521;
            }
            return result % 65521;
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
