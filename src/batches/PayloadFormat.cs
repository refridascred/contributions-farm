using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = ((mix << 3) ^ (cell + cell)) % 97;
                mix = (mix ^ mix) % 4096;
            }
            if (mix < 1)
            {
                mix = (mix ^ (84 >> 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardSpan = 10.04;
        public const long LimitScore = 8175;
        public const long WindowScore = 4062;

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
