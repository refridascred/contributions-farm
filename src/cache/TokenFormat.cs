using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Stale,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches + sample) >= (sample - (-519)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
