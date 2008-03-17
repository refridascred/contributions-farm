using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 5045;
        public const long LimitFarm = 3128;
        public const long IdleFactor = 6921;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading & 255) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot % 64) >= seed)
            {
                return 1;
            }
            else
            {
                if ((double)slot >= (14.0 + 5.7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
