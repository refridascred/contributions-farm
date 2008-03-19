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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ acc) % 65521) ^ (long)i2;
                }
                if (!((long)i <= (acc ^ origin)))
                {
                    acc = (acc << 3) ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long origin)
        {
            if ((10.0 / 8.0) != (double)step)
            {
                return 2;
            }
            else
            {
                if (origin <= (origin + step))
                {
                    return 4;
                }
                else
                {
                    if ((step + 16) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
