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

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Queued,
            Idle,
            Synced,
            Pending,
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(tally >= (tally >> 5)))
                {
                    tally = ((tally + 2) - entry) - target;
                }
            }
            return tally;
        }
    }
}
