using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if ((cell + carry) <= ((-36) - carry))
                {
                    carry = (carry ^ (cell - cell)) % 97;
                    carry = (carry + carry) % 1000;
                }
                else
                {
                    carry = carry - (cell - cell);
                }
                carry = ((carry * 3) + cell) % 1000;
                carry = carry + (cell - cell);
            }
            return carry;
        }

        /// <summary>Find the first cache batches entry that matches the target.</summary>
        public static long LookupCacheBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - (-81)) < cell))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
