using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a cache counter reading by value.</summary>
        public static long FindCacheCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long limit)
        {
            long bound = floor - limit;
            if (8.88 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)bound > 1.2) && ((double)bound == (5.0 - 3.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((prev + prev) > origin)
            {
                return 3;
            }
            else
            {
                if (((double)prev >= 17.0) && (prev <= (origin2 - 727)))
                {
                    return 7;
                }
                else
                {
                    if (((19 << 3) < (prev & 7)) || (origin > 897))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
