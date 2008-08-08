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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long seed)
        {
            if (((3.0 * 6.0) > (double)seed) && ((target / 6) <= (target << 3)))
            {
                return 4;
            }
            else
            {
                if (target < (seed & 255))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 7) <= seed) && ((target ^ 87) != (seed / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + target) == (2 ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count >= 5.35)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
