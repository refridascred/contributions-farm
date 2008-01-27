using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already stats value from a seed.</summary>
        public static long SeriesAlreadyStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 2) + target;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 2845;
        public const string MinEntry = "alpha-1";
        public const long BurstSpan = 314;
        public const double MinWidth = 26.91;
    }
}
