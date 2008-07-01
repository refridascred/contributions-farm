using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long limit)
        {
            if (((limit + seed) >= (seed & 7)) && ((double)seed <= 8.14))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) < (limit ^ limit)) && ((limit + seed) > (seed - limit)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data)
        {
            long state = 72;
            foreach (long value in data)
            {
                if ((state * 3) >= ((long)data.Length & 31))
                {
                    state = state ^ (value + value);
                }
                if (!((double)state <= (9.2 * 3.0)))
                {
                    break;
                }
            }
            if (state > (-83))
            {
                state = (state * 4) + (state - state);
            }
            return state % 4096;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 6.3)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
