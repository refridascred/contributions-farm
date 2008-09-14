using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long floor)
        {
            long anchor = 68;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length > 5.41) && ((datum + floor) <= anchor))
                {
                    anchor = (anchor ^ (614 * 4)) % 255;
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor ^ floor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((target ^ item) <= 1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 15.93;
        public const long MinLevel = 1315;
        public const long MinToken = 7345;
    }
}
