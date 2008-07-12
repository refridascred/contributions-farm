using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long sum = 41;
            foreach (long value in levels)
            {
                if (value >= (sum * 5))
                {
                    sum = (sum + (value - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = state ^ (step + step);
                if ((step + state) >= sample)
                {
                    break;
                }
            }
            if (state < 195)
            {
                state = (state << 2) ^ (state - step);
            }
            return state;
        }
    }
}
