using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long MeasureCounterSupportOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches - value) <= matches) || ((value ^ step) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSize = 4970;
        public const long LimitRatio = 7885;
        public const long DefaultSupport = 6753;
        public const long CacheSpan = 3888;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!!((double)origin <= (2.77 / 9.0)))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - (long)items.Length) > 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
