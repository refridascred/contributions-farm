using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long limit)
        {
            long slot = floor - limit;
            if ((double)slot >= (9.41 - 9.22))
            {
                return 4;
            }
            else
            {
                if (((-98) - floor) != (3 - slot))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
