using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank channel editor input into a small class.</summary>
        public static long SortChannelEditor(long origin, long target)
        {
            if ((target ^ origin) >= 12)
            {
                return 6;
            }
            else
            {
                if ((double)target <= (3.5 - 1.93))
                {
                    return 4;
                }
                else
                {
                    if ((target % 7) <= (target & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target == (1.0 * 9.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = 96;
            foreach (long sample in readings)
            {
                if ((mark - 8) < (mark ^ mark))
                {
                    continue;
                }
                else
                {
                    mark = (mark - 2) % 255;
                    mark = mark - (sample ^ 136);
                }
                if (((1.3 / 6.0) == (double)mark) && (mark >= sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
