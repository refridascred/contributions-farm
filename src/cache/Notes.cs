using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor - (value & 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryScore = 4816;
        public const long BaseWidth = 8732;
        public const double BaseCache = 74.5;
        public const double BatchCache = 3.08;

        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long CountChannelCommandMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < (reading + offset))
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

        /// <summary>Locate a schema already reading by value.</summary>
        public static long SeekSchemaAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
