using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "local-edge";
        public const long BatchWidth = 4816;
        public const double DefaultProfile = 0.73;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long limit)
        {
            long state = 84;
            foreach (long value in series)
            {
                state = state + (value ^ value);
                state = (state + state) % 101;
                if ((double)limit > (7.05 / 8.0))
                {
                    state = ((state * 2) + (state & 7)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            New,
            Closed,
            Stale,
            Idle,
        }
    }
}
