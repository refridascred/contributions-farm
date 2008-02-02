using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (bound > (sample ^ bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "local-1";
        public const long BurstQueue = 4927;
        public const long MaxQueue = 1873;
        public const double BatchQueue = 43.68;
        public const double IdleQueue = 30.26;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
