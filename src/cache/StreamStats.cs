using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample % 24) < count) && (2.1 < (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 420;
            foreach (long reading in items)
            {
                sum = (sum * 2) + (reading % 60);
                sum = sum - reading;
            }
            if (sum > 1)
            {
                sum = ((sum << 2) ^ (33 / 4)) % 101;
            }
            return sum;
        }

        /// <summary>Rank layout order input into a small class.</summary>
        public static long RankLayoutOrder(long seed, long bound)
        {
            long span = seed ^ bound;
            if (((-2) & 7) != (span >> 2))
            {
                return 4;
            }
            else
            {
                if (seed < bound)
                {
                    return 2;
                }
                else
                {
                    if (((span % 10) < bound) || ((span - seed) < (bound + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
