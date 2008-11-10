using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics tools entries that pass the check.</summary>
        public static long MeasureMetricsToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >> 3) != (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long MeasureAccountEditorGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)step < (double)2) || ((79 + step) == ((-149) * 3)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
