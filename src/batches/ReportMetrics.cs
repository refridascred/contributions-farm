using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((cell % 8) == (cell + cell))
                {
                    mix = (mix << 2) ^ (mix + 457);
                    mix = ((mix << 3) ^ (mix << 2)) % 255;
                }
                if ((193 >> 1) > mix)
                {
                    mix = (mix + (mix >> 2)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            New,
            Paused,
            Dropped,
            Closed,
        }
    }
}
