using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if (result < (long)i)
                {
                    result = result ^ result;
                }
                else
                {
                    result = (result ^ (result / 3)) % 1000;
                }
                result = (result ^ (result + offset)) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long TallyGithubfarmFilterGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)seed <= 20.0)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (double)item)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 1;
            foreach (long cell in items)
            {
                state = ((state ^ state) % 4096) ^ cell;
                state = (state * 3) + (state * 3);
                if ((double)14 == (double)state)
                {
                    break;
                }
            }
            if (state < 680)
            {
                state = ((state << 2) ^ (37 / 3)) % 65521;
            }
            return state % 97;
        }
    }
}
