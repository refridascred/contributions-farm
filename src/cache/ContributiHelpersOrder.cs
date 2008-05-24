using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-7) > floor) || ((8 / 2) != (value & 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
