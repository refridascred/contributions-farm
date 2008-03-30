using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long diff = (mix ^ mix) ^ (mix << 1);
                    mix = ((mix + (diff ^ diff)) % 1000) ^ (long)i2;
                }
                mix = ((mix << 2) ^ (3 << 2)) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Done,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long step2)
        {
            if (!((3.0 + 7.0) >= (double)step2))
            {
                return 1;
            }
            else
            {
                if ((step << 3) != (step2 & 63))
                {
                    return 4;
                }
                else
                {
                    if (91 <= (step2 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
