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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Done,
            Paused,
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
