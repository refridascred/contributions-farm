using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) != (long)readings.Length) && (((cell / 9) >= seen) || ((seen / 3) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if (((item + mark) < (1 - item)) || ((double)mark == (4.4 + 2.8)))
                {
                    mark = (mark << 3) ^ (item - item);
                }
            }
            return mark;
        }
    }
}
