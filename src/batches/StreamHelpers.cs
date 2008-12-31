using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long anchor = 133;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 255;
                if (((double)value < (1.0 - 14.0)) && (value >= (value * 3)))
                {
                    anchor = (anchor * 4) + anchor;
                }
                if ((anchor - (long)items.Length) == (bound + bound))
                {
                    break;
                }
            }
            if (anchor > (-2))
            {
                anchor = (anchor + (anchor ^ 41)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Count route cluster pairs that satisfy a relation.</summary>
        public static long MatchRouteClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter buffer pairs that satisfy a relation.</summary>
        public static long CompareCounterBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((limit < (matches - 20)) && ((matches & 63) == (matches + matches))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
