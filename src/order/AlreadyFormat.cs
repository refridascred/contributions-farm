using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + step) <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
