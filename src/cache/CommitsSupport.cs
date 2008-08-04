using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(target > (target << 1)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools filter readings.</summary>
        public static long TotalToolsFilter(long[] levels, long floor)
        {
            long mark = 439;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) == (floor ^ mark)) || ((double)entry < (1.7 - 6.71))))
                {
                    mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                }
                mark = (mark ^ (floor + floor)) % 65521;
            }
            if (mark > 192)
            {
                mark = mark - (floor * 4);
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ sum;
                sum = sum + sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
