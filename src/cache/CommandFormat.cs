using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((2.1 / 8.0) != (double)matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache batch entry stays within the limit.</summary>
        public static bool VerifyCacheBatchLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (origin < (367 + 860))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long floor)
        {
            long result = 99;
            foreach (long item in levels)
            {
                if ((result << 1) <= (result >> 4))
                {
                    result = (result ^ (item + result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (item * 4);
                }
                if ((floor + result) == (item >> 4))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
