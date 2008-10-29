using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally < (5.7 / 2.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Active,
            Locked,
            Failed,
        }
    }
}
