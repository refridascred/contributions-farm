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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound << 3) == (anchor % 3))
                {
                    anchor = (anchor - (368 + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheTimeout = 4357;
        public const double HardDepth = 24.99;
        public const long LimitSchema = 1734;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
