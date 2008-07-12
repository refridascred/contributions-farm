using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((9.56 * 4.3) < (double)hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first session batch entry that matches the target.</summary>
        public static long FindSessionBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits <= (double)(-8))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer batch reading by value.</summary>
        public static long FindBufferBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "standard-1";
        public const double BaseWidth = 24.99;
        public const long DefaultCount = 9337;
    }
}
