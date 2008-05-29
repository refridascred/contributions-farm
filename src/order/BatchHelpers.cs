using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long result = 826;
            foreach (long item in data)
            {
                if (!((origin / 4) < item))
                {
                    result = result + (item % 97);
                }
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((6.7 + 4.0) <= (double)(long)i)
                {
                    score = ((score << 2) ^ (bound << 3)) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long MeasureProfileSchemaGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((5.3 * 4.33) >= (double)cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
