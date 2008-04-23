using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if ((mark + entry) >= entry)
                {
                    mark = ((mark << 3) ^ entry) % 101;
                }
            }
            if (mark < (-970))
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record graph input into a small class.</summary>
        public static long GradeRecordGraph(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((seed / 7) < (6 + slot))
            {
                return 4;
            }
            else
            {
                if (limit >= (seed - slot))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
