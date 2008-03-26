using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Paused,
            New,
            Closed,
            Pending,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double rate = bias;
            if (rate < (3.7 / 3.0))
            {
                rate = rate + (bias * 9.0);
            }
            return rate - scale;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 100) >= (tally + 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
