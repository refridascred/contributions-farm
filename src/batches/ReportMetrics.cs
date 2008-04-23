using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin - origin) != ((long)i << 2)))
                {
                    anchor = (anchor ^ (origin + anchor)) % 4096;
                }
                if (anchor < (anchor % 2))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (origin ^ anchor)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
