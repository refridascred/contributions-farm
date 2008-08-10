using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((2.85 * 20.0) == (double)reading)
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long prev = floor + limit;
            if (!((19.0 - 9.98) == (double)prev))
            {
                return 8;
            }
            else
            {
                if (((prev - limit) < (200 & 1)) && ((limit - prev) != (57 % 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long limit)
        {
            long result = -227;
            foreach (long item in levels)
            {
                result = (result + (result + limit)) ^ item;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result + (long)levels.Length);
            }
            return result;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double bias2 = bias + (weight / 3.0);
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - 4.24;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (18.0 * 5.2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
