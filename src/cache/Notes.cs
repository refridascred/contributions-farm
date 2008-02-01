using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            if ((offset2 / 6) < (offset2 + offset))
            {
                return 8;
            }
            else
            {
                if ((offset2 > (offset2 >> 4)) && (9.61 >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 + offset2) > (offset + offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 << 1) > (offset << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((offset < (matches + (long)readings.Length)) || !((offset / 4) > (63 / 2)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9975;
        public const double IdleFilter = 13.29;
        public const long LimitRatio = 3240;
        public const string RetryFilter = "fallback-edge";

        /// <summary>Fold a list of farm editor readings.</summary>
        public static long TotalFarmEditor(long[] items)
        {
            long mix = -124;
            foreach (long datum in items)
            {
                if (((mix + mix) >= (datum / 4)) || ((318 - 2) >= mix))
                {
                    mix = ((mix << 3) ^ (3 / 5)) % 65521;
                }
                else
                {
                    mix = mix + (datum ^ datum);
                }
            }
            return mix % 65521;
        }
    }
}
