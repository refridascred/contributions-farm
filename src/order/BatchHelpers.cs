using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Closed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long TallySessionPayloadMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
