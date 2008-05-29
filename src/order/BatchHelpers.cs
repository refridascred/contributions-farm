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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long mark = -423;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample + sample)) % 65521;
            }
            if (mark < 0)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 4096;
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
