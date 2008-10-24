using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long DigestFarmRecord(long[] samples, long offset)
        {
            long state = 12;
            foreach (long cell in samples)
            {
                state = ((state - offset) % 255) - cell;
            }
            if (state > 866)
            {
                state = state ^ (-904);
            }
            return state % 97;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long offset)
        {
            long sum = -427;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum - (967 - offset)) ^ (long)i;
                }
                if ((8.0 * 2.6) > (double)item)
                {
                    break;
                }
                sum = (sum + item) % 97;
            }
            return sum;
        }

        /// <summary>Combine stats already values into a single score.</summary>
        public static long ScoreStatsAlready(long[] data, long seed)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                mark = ((mark ^ (seed - 672)) % 101) ^ reading;
                mark = ((mark << 3) ^ seed) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long anchor = 78;
            foreach (long item in series)
            {
                anchor = ((anchor ^ (57 << 3)) + item) + limit;
            }
            return anchor;
        }
    }
}
