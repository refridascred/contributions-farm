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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long step)
        {
            long step2 = offset ^ step;
            if (step2 < (offset * 3))
            {
                return 5;
            }
            else
            {
                if ((step2 >= (step2 << 3)) && ((step + offset) > (offset & 15)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
