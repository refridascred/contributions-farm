using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long offset)
        {
            long carry = 2;
            foreach (long entry in values)
            {
                if ((offset > (carry + entry)) && (((long)values.Length >> 1) > (carry << 2)))
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TotalEditorStream(long[] samples, long origin)
        {
            long acc = 702;
            foreach (long cell in samples)
            {
                if (((14.0 / 7.0) == (double)cell) && (origin >= (cell >> 2)))
                {
                    break;
                }
                if ((cell << 2) >= (acc - cell))
                {
                    acc = ((acc * 3) + (acc + origin)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            if (acc > (-6))
            {
                acc = (acc << 3) ^ (58 ^ origin);
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
