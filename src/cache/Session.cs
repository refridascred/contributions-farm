using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
