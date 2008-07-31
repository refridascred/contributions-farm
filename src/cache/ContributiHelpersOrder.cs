using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ 16;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            long span = step ^ floor;
            if (((double)step < (0.46 - 9.12)) || ((double)step != (2.65 - 9.94)))
            {
                return 4;
            }
            else
            {
                if ((step >= (25 % 7)) || ((span + floor) < 7))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Paused,
            Retry,
            New,
        }
    }
}
