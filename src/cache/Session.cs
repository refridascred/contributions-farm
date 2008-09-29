using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Closed,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate record graph samples.</summary>
        public static long WeighRecordGraph(long[] values, long target)
        {
            long mix = 0;
            foreach (long item in values)
            {
                if (mix >= (item >> 2))
                {
                    mix = (mix ^ (2 * 5)) - target;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
