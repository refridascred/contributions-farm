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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (seed & 15)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
