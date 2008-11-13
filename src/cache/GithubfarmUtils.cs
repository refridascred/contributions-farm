using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long step, long limit)
        {
            long gap = step + limit;
            if ((gap >> 5) != (step % 8))
            {
                return 0;
            }
            else
            {
                if (!((gap ^ gap) <= (limit % 7)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (9.53 * 7.2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2 % 2) >= (step + gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches payload samples.</summary>
        public static long MatchBatchesPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
