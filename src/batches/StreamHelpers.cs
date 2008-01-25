using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long step)
        {
            long delta = bound + step;
            if (bound >= (delta + bound))
            {
                return 0;
            }
            else
            {
                if (5 > (step >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next batch farm value from a seed.</summary>
        public static long RollBatchFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor ^ anchor;
                if (step < (step >> 3))
                {
                    long count = step + (anchor / 9);
                    anchor = (anchor * 3) + (count * 4);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long floor)
        {
            long anchor = 28;
            foreach (long entry in data)
            {
                if (anchor > (entry + anchor))
                {
                    anchor = (anchor - (entry + (long)data.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ floor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (((mark * 3) + value) % 97) - (long)i;
                }
                mark = mark ^ ((long)samples.Length / 4);
            }
            return mark;
        }
    }
}
