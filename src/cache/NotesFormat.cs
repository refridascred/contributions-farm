using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            long lane = target - limit;
            if (!((target << 2) != (limit - 1)))
            {
                return 3;
            }
            else
            {
                if ((8.4 + 8.0) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((limit + target) < (lane + lane)) && (limit <= (target / 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long anchor = 63;
            foreach (long item in readings)
            {
                bool ready = (anchor / 6) != (item + 36);
                if (ready)
                {
                    anchor = (anchor + (item >> 2)) % 101;
                }
                if ((item ^ anchor) == (anchor - anchor))
                {
                    anchor = (anchor + (148 << 1)) % 4096;
                }
            }
            if (anchor < 183)
            {
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
