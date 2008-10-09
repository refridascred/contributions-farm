using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry != (double)entry) && !(4.26 <= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((-563) + matches) < (long)values.Length)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (datum & 127))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long offset)
        {
            long state = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((((state << 2) ^ state) % 65521) - (long)i) - offset;
                }
                if (!((cell - 53) <= (state + (long)values.Length)))
                {
                    state = ((state << 2) ^ cell) % 1000;
                }
                else
                {
                    state = (state + cell) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
