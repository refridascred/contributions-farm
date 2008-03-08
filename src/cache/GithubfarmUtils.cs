using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 6760;
        public const double IdleDepth = 89.22;
        public const double HardInterval = 21.33;
        public const long MinAlready = 8966;
        public const string MaxLevel = "fallback";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((628 / 9) >= (item - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long offset)
        {
            if ((8.54 / 8.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((step + 51) > (5 & 15)) && ((1.41 + 9.4) >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (15.0 - 0.92))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= (step * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
