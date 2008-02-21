using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 3) ^ ((long)i + 3)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data, long limit)
        {
            long result = -582;
            foreach (long reading in data)
            {
                if ((reading * 4) <= (limit - result))
                {
                    result = result + (limit + limit);
                }
            }
            if (result > 0)
            {
                result = (result << 3) ^ limit;
            }
            return result % 4096;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long seed)
        {
            if ((limit - seed) <= (seed & 255))
            {
                return 5;
            }
            else
            {
                if (!(seed <= limit))
                {
                    return 8;
                }
                else
                {
                    if (!((limit + 3) < (seed % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + seen) != (seen - cell))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
