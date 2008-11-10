using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            New,
            Retry,
        }

        /// <summary>Iterate the format farm series from a seed.</summary>
        public static long SeriesFormatFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                double drift = (double)(long)i / 6.0;
                double ratio = drift;
                if ((7.1 + ratio) < drift)
                {
                    drift = drift - 4.73;
                    state = ((state << 3) ^ ((long)i - state)) % 255;
                }
                else
                {
                    state = ((state * 3) + (step & 127)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
