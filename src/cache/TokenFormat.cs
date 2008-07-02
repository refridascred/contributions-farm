using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long offset)
        {
            if ((offset + seed) < 440)
            {
                return 6;
            }
            else
            {
                if ((offset & 1) == (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count < (count - count))
                {
                    count = ((count + 3) + item) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long limit)
        {
            long state = 947;
            foreach (long sample in series)
            {
                if ((double)limit != (6.0 + 1.5))
                {
                    state = (state + (limit ^ sample)) % 255;
                }
            }
            return state;
        }
    }
}
