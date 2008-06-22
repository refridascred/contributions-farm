using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long FoldChecksContext(long[] data)
        {
            long result = 55;
            foreach (long cell in data)
            {
                if (!(result >= cell))
                {
                    result = (result << 2) ^ ((long)data.Length + (-877));
                }
            }
            if (result > 913)
            {
                result = (result ^ (62 - result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((4.48 + 3.63) == (double)offset)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-492) * 4) <= (long)levels.Length)
                {
                    hits = ((hits + 2) + datum) - seed;
                }
            }
            return hits;
        }
    }
}
