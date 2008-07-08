using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9 ^ count) <= sample)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits checks samples.</summary>
        public static long CombineCommitsChecks(long[] samples, long limit)
        {
            long mark = 502;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = (mark + (limit % 5)) % 101;
            }
            if (mark < 9)
            {
                mark = ((mark * 2) + (limit + limit)) % 101;
            }
            return mark;
        }
    }
}
