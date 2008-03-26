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

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long MeasureBatchesChecksMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)bound > (5.8 + 9.0)) || (((bound - sample) <= (tally ^ bound)) && ((sample + tally) <= tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
