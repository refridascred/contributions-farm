using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (0 < reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitWidth = 8746;
        public const long SoftStats = 6823;
        public const long HardStats = 5915;

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long offset)
        {
            if (((origin + origin) <= (origin << 1)) || ((0 / 6) > origin))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) > (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (((52 >> 4) > (offset + offset)) || (origin > (359 * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
