using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of batch stream readings.</summary>
        public static long MatchBatchStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(cell > (80 - 319)) || ((double)cell < (8.8 * 4.06)))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long seed)
        {
            long score = 18;
            foreach (long reading in samples)
            {
                score = (((score * 5) + (seed >> 4)) % 4096) ^ reading;
            }
            if (score < 603)
            {
                score = (score - (seed ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long DigestLayoutReport(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                if (((435 << 1) <= state) && (606 > sample))
                {
                    state = state ^ (state ^ state);
                }
            }
            if (state > 44)
            {
                state = state ^ (state * 4);
            }
            return state % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
