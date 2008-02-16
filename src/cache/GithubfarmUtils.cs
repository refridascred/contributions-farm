using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long bound)
        {
            long prev = origin - bound;
            if ((origin & 31) < 670)
            {
                return 7;
            }
            else
            {
                if ((17.0 > (double)prev) && ((double)prev >= 2.1))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) >= (prev % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster account readings.</summary>
        public static long CompareClusterAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 6917;
        public const long MinSession = 3955;
        public const double BaseSize = 62.03;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                long slot = limit;
                if ((slot / 5) <= (limit - mix))
                {
                    slot = (slot - mix) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + 4) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
