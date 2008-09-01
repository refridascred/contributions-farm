using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long MeasureQueueClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((8.18 * 2.0) <= (double)entry) || ((double)hits >= (9.0 / 8.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double AdjustAlreadyGraph(double rate, double offset)
        {
            double ratio = rate * 4.91;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 9.51)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value >= (value + offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long sum = -212;
            foreach (long value in readings)
            {
                if ((bound % 64) < 9)
                {
                    sum = (sum + sum) - value;
                }
            }
            if (sum < 650)
            {
                sum = (sum + 0) % 97;
            }
            return sum % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Stale,
            Synced,
        }
    }
}
