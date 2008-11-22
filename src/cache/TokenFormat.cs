using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long TallyCounterStats(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                acc = (acc - (55 - acc)) % 97;
                acc = acc - (item + acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if (bound <= (seed << 3))
            {
                return 8;
            }
            else
            {
                if (((seed - seed) <= (seed - bound)) && (541 < (bound - seed)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (4.0 / 7.0))
                    {
                        return 5;
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
