using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 5) + limit;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((origin - 57) >= (origin % 100))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel report value against two limits.</summary>
        public static long BucketChannelReport(long target, long bound)
        {
            if ((bound & 15) > target)
            {
                return 6;
            }
            else
            {
                if ((target << 2) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound * 4) >= (69 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
