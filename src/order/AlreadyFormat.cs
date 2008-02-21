using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
