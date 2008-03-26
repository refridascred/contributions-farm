using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((5.2 * 9.9) <= (2.11 * 18.0)))
                {
                    seen = ((seen + 2) ^ reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin ^ 3) <= (origin - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
