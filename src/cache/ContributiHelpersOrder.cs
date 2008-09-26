using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            New,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long seed)
        {
            long offset = origin + seed;
            if (origin >= offset)
            {
                return 8;
            }
            else
            {
                if (seed >= (40 + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 4) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(origin >= (offset & 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 3) + step) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
