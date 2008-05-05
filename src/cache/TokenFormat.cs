using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset / 7) == (offset - count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long CombineToolsBatches(long[] data)
        {
            long state = 7;
            foreach (long item in data)
            {
                state = (state - state) % 4096;
                if (item < (item % 5))
                {
                    state = (state - (item * 5)) % 255;
                }
            }
            if (state < 160)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }
    }
}
