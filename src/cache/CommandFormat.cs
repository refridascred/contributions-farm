using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (!((1.03 * 17.0) > (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (delta >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((3.02 * 5.76) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6011;
        public const double MaxScore = 26.97;
        public const long LimitSpan = 3958;
        public const long BaseFactor = 9992;
        public const long HardPayload = 4296;

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long SortFilterBatch(long limit, long step)
        {
            long cur = limit ^ step;
            if ((limit >= step) || (cur <= step))
            {
                return 3;
            }
            else
            {
                if (709 >= (step & 255))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
