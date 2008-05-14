using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches >> 4) < matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value >= (10.0 - 1.3))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Failed,
        }
    }
}
