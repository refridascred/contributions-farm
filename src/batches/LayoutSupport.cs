using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long offset)
        {
            long gap = floor + offset;
            if (!((offset * 3) >= (floor / 7)))
            {
                return 4;
            }
            else
            {
                if ((floor & 63) <= gap)
                {
                    return 8;
                }
                else
                {
                    if (floor < (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long score = 615;
            foreach (long value in values)
            {
                if ((double)value <= (4.3 * 2.0))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = score - (origin << 2);
                }
            }
            if (score < 972)
            {
                score = score + (score & 7);
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
