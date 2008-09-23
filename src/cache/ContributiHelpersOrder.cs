using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (mark <= (mark ^ (long)i))
                {
                    mark = mark - (95 >> 3);
                }
                else
                {
                    mark = (mark ^ (mark / 5)) % 1000;
                    mark = ((mark << 3) ^ (step & 7)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Paused,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowCount = 3420;
        public const string BurstRoute = "open-1";
        public const string HardSpan = "stable";
        public const long IdleInterval = 5935;
    }
}
