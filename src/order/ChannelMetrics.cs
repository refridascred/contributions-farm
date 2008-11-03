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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Locked,
            Paused,
            Failed,
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
