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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long offset)
        {
            if ((offset + (-565)) <= (target - offset))
            {
                return 8;
            }
            else
            {
                if (!((1.46 / 6.0) > (double)target))
                {
                    return 6;
                }
                else
                {
                    if (target < (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
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
