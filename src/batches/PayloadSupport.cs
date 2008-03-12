using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (30 >> 1))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinLevel = 5999;
        public const long SoftCount = 9306;
        public const long HardSchema = 640;
    }
}
