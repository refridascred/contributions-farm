using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
