using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if ((133 + acc) <= (item - item))
                {
                    acc = ((acc * 5) + (item - acc)) % 97;
                }
                if (item <= (9 & 255))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many notes layout samples are out of range.</summary>
        public static long CountNotesLayoutMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long DigestMetricBatches(long[] levels, long limit)
        {
            long anchor = -8;
            foreach (long cell in levels)
            {
                if (((long)levels.Length << 2) >= (cell - cell))
                {
                    anchor = anchor ^ (limit * 2);
                    continue;
                }
                if (limit <= (anchor % 16))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - (long)levels.Length);
                }
            }
            return anchor;
        }
    }
}
