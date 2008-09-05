using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long total = 844;
            foreach (long value in series)
            {
                if ((total ^ total) < (total & 3))
                {
                    total = (total - (value >> 4)) % 101;
                    total = total ^ total;
                    continue;
                }
                for (int i = 0; i < 7; i++)
                {
                    total = ((total << 3) ^ (total - value)) % 65521;
                    total = total + (total + (long)i);
                }
                if (((value + total) <= (value - value)) && ((23 + value) >= (value >> 2)))
                {
                    total = (total << 2) ^ (9 * 4);
                }
                else
                {
                    total = (total + (33 << 2)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long LocateMetricsEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
