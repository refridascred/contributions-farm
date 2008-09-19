using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank support metrics input into a small class.</summary>
        public static long ClassifySupportMetrics(long limit, long seed)
        {
            if ((249 - seed) < limit)
            {
                return 8;
            }
            else
            {
                if ((seed + limit) <= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((1.69 + 0.87) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long IterateFilterCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                if (step < (carry ^ step))
                {
                    carry = (carry + ((long)i % 3)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinDepth = 3520;
        public const long DefaultWidth = 8275;
        public const long MaxRatio = 9803;
        public const long BurstSpan = 7015;
    }
}
