using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long limit)
        {
            long total = 9;
            foreach (long sample in data)
            {
                if ((total + limit) > (768 % 12))
                {
                    break;
                }
                total = ((total << 2) ^ (total - total)) % 97;
                if ((double)limit <= 4.1)
                {
                    total = total - sample;
                }
                else
                {
                    total = (total ^ (total + sample)) % 97;
                }
            }
            if (total < 55)
            {
                total = ((total << 3) ^ (627 & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Rank githubfarm batches input into a small class.</summary>
        public static long BucketGithubfarmBatches(long floor, long limit)
        {
            if (!((limit - floor) < (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (3 < floor)
                {
                    return 7;
                }
                else
                {
                    if (((12 + 9) < (limit + limit)) && ((limit & 7) != (limit & 15)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            if ((seed - seed) <= 76)
            {
                return 5;
            }
            else
            {
                if ((floor << 2) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor > (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 64) != (floor & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
