using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of schema farm readings.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank filter batches input into a small class.</summary>
        public static long SortFilterBatches(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((0.13 < (double)seed2) && (lane > (lane << 1)))
            {
                return 8;
            }
            else
            {
                if ((1 >= (seed ^ lane)) || ((double)seed2 <= 5.78))
                {
                    return 5;
                }
                else
                {
                    if (((lane + seed2) <= lane) || (9 <= (seed - seed2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + seed2) < (seed2 - seed2)) && ((seed - (-13)) >= (lane * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
