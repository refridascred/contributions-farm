using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((seed >= cur) || ((5 << 1) >= (cur ^ seed2)))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (8.0 - 1.34))
                {
                    return 4;
                }
                else
                {
                    if (((double)cur == (12.0 * 9.3)) && (cur < (seed2 + 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed2 << 2) < seed2))
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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    score = (score * 2) + (long)i3;
                }
                for (int i4 = 0; i4 < 12; i4++)
                {
                    score = (((score * 4) + (long)i) % 65521) ^ (long)i4;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long carry = 720;
            foreach (long entry in data)
            {
                carry = (carry - (origin & 63)) ^ entry;
                if ((83 % 12) <= (carry - 560))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
