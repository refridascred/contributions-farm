using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long total = -97;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 4096) ^ item;
            }
            return total % 1000;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed << 1) > (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((5.3 * 9.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor * 2) < (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (target / 6)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
