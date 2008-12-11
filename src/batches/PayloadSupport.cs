using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix * 2) + ((long)i2 >> 3);
                    mix = (mix * 3) + (origin >> 5);
                }
                if ((origin * 3) < mix)
                {
                    mix = (mix ^ (long)i) % 255;
                    mix = ((mix << 2) ^ (long)i) % 101;
                }
                else
                {
                    mix = (mix * 3) + (mix >> 2);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Active,
            Stale,
            New,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Stale,
            Paused,
            Retry,
            Synced,
        }
    }
}
