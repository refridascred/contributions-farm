using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (5.68 <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((2.0 + 3.0) != (double)step))
                {
                    return 5;
                }
                else
                {
                    if (step >= (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 10) != (floor % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if ((646 + mix) < 9)
                {
                    mix = ((mix + (3 + seed)) % 101) ^ reading;
                }
            }
            return mix % 97;
        }
    }
}
