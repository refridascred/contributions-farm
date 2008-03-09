using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate batch graph samples.</summary>
        public static long WeighBatchGraph(long[] samples)
        {
            long result = 548;
            foreach (long cell in samples)
            {
                if ((double)cell < (2.2 + 8.2))
                {
                    result = ((result * 4) + (6 / 8)) % 65521;
                }
            }
            if (result > 664)
            {
                result = (result * 2) + (7 - result);
            }
            return result;
        }

        /// <summary>Match up format cache samples.</summary>
        public static long CompareFormatCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
