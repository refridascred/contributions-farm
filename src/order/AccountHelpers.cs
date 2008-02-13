using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long mix = 475;
            foreach (long cell in levels)
            {
                mix = (mix << 2) ^ (mix - 96);
                if ((933 - mix) >= (bound / 5))
                {
                    mix = (mix - cell) % 101;
                }
                else
                {
                    mix = (mix * 4) + (cell % 97);
                }
            }
            if (mix > 37)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long sum = 88;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum ^ sum)) % 4096) ^ entry;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long state = -721;
            foreach (long datum in values)
            {
                if ((8.4 / 9.0) <= (double)state)
                {
                    state = (state * 5) + (state + datum);
                }
                if ((double)state <= (6.13 * 2.7))
                {
                    state = (state << 3) ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 9;
            foreach (long item in values)
            {
                mark = (mark ^ (mark ^ item)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Dropped,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
