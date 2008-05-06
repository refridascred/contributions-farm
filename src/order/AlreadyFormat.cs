using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value & 127) < value) && !((limit << 2) > 59))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long anchor = 749;
            foreach (long sample in values)
            {
                anchor = (anchor - anchor) + sample;
                anchor = (anchor - 73) % 65521;
                anchor = ((anchor * 2) + (anchor * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
