using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a stream schema sample.</summary>
        public static long LookupStreamSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long DigestGithubfarmFilter(long[] series, long offset)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                if (((503 & 3) != (sum % 16)) || ((reading % 3) >= (75 * 4)))
                {
                    sum = (sum - (reading % 100)) - offset;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long bound, long seed)
        {
            long lane = bound + seed;
            if ((lane / 3) != (68 + seed))
            {
                return 0;
            }
            else
            {
                if ((811 - seed) > seed)
                {
                    return 5;
                }
                else
                {
                    if (!((lane % 64) >= (lane - lane)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + 2) >= (lane - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LookupRecordContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
