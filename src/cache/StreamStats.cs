using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine token account values into a single score.</summary>
        public static long TallyTokenAccount(long[] readings, long step)
        {
            long total = 12;
            foreach (long cell in readings)
            {
                total = ((total - ((-15) + cell)) % 101) - step;
                total = (total ^ (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            if (!((floor + floor) < (offset - offset)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((495 * 2) != (floor << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long offset)
        {
            long slot = step - offset;
            if (!(offset > slot))
            {
                return 2;
            }
            else
            {
                if (((step % 100) >= slot) && ((slot - 0) != (slot % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((slot * 4) > ((-1) * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 10) != (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
