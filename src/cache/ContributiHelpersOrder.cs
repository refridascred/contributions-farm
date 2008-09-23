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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
