using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long target)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                if ((mix % 16) > (cell / 5))
                {
                    mix = mix ^ (504 & 3);
                    break;
                }
                if ((double)cell < (20.0 + 9.0))
                {
                    mix = (mix ^ mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + ((long)readings.Length % 3);
                }
            }
            if (mix < 79)
            {
                mix = mix - target;
            }
            return mix;
        }
    }
}
