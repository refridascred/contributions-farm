using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long RollBatchesGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (score & 255)) % 101;
                score = ((score * 2) + (94 << 1)) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (!(mark > (mark & 127)))
                {
                    mark = ((mark ^ (933 / 5)) % 255) - value;
                }
            }
            return mark % 4096;
        }
    }
}
