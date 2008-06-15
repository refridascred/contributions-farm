using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long bound)
        {
            if (origin < bound)
            {
                return 8;
            }
            else
            {
                if ((8.06 + 2.0) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((origin & 1) != (origin << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix ^ mix) % 1000) ^ (long)i2;
                }
                mix = (mix - origin) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
