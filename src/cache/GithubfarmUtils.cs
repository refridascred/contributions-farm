using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long origin, long step)
        {
            long diff = origin ^ step;
            if ((origin % 16) == (step & 7))
            {
                return 0;
            }
            else
            {
                if (step >= diff)
                {
                    return 1;
                }
                else
                {
                    if ((469 % 97) < (origin + 27))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            if (((origin & 15) <= (seed + origin)) || ((double)seed > (double)4))
            {
                return 2;
            }
            else
            {
                if ((seed % 3) == (1 * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long OverlapFormatWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
