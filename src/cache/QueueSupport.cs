using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor2 >> 1) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((double)gap < (14.0 + 4.4))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
