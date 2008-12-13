using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((seed / 3) >= (long)readings.Length)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the order window entries that pass the check.</summary>
        public static long MeasureOrderWindowHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) != (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item < (6.4 * 7.04)) || !(count < item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Retry,
            Active,
            Pending,
        }
    }
}
