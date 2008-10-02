using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (9 << 3)) % 255;
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Accumulate session record samples.</summary>
        public static long CombineSessionRecord(long[] samples)
        {
            long state = 26;
            foreach (long item in samples)
            {
                if (state <= ((-53) >> 3))
                {
                    state = ((state ^ (state + 679)) % 4096) ^ item;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long step)
        {
            long total = 65;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample + sample)) + step;
            }
            return total % 4096;
        }
    }
}
