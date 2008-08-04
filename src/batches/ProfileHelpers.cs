using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if ((origin <= (92 >> 4)) || ((anchor & 3) >= (origin << 1)))
                {
                    anchor = (anchor << 2) ^ entry;
                }
            }
            if (anchor < (-7))
            {
                anchor = ((anchor << 3) ^ (origin / 8)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
