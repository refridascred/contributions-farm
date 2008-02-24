using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6011;
        public const double MaxScore = 26.97;
        public const long LimitSpan = 3958;
        public const long BaseFactor = 9992;
        public const long HardPayload = 4296;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + (long)levels.Length) > cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
