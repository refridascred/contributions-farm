using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Count checks contributi pairs that satisfy a relation.</summary>
        public static long PairChecksContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (step << 2)) % 65521;
                mix = mix - (77 - 29);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
