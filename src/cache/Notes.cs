using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "stable-edge";
        public const long SoftLevel = 1542;
        public const long MaxSize = 4871;
        public const long BurstLevel = 2901;
        public const string WindowSpan = "fallback-1";

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long step)
        {
            long cur = limit + step;
            if (!((limit * 3) == (limit & 7)))
            {
                return 0;
            }
            else
            {
                if ((double)cur > (1.8 + 11.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long seed)
        {
            if (((-7) + seed) <= seed)
            {
                return 5;
            }
            else
            {
                if (((seed * 4) == (step << 3)) && ((double)seed > (1.0 + 6.4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed != (3.5 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((851 + step) >= (step + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long seed)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if ((double)sum == (8.33 - 0.75))
                {
                    sum = (sum << 2) ^ seed;
                }
                else
                {
                    sum = (sum ^ (reading + 56)) % 4096;
                }
                if (((6.69 / 9.0) >= (double)seed) && (19 <= (sum + seed)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
