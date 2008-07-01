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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
