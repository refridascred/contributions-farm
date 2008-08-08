using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the layout channel series from a seed.</summary>
        public static long SeriesLayoutChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((16.0 - 3.0) >= (double)floor)
                {
                    sum = ((sum << 3) ^ floor) % 1000;
                    sum = ((sum * 4) + sum) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum ^ (floor + 37)) % 65521;
                    sum = sum - floor;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Derive the next cluster route value from a seed.</summary>
        public static long IterateClusterRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc << 3) ^ acc) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
