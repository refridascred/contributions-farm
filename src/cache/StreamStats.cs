using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long step)
        {
            long state = 91;
            foreach (long sample in levels)
            {
                if (((2.0 + 3.7) > (double)state) || ((step / 7) > 91))
                {
                    break;
                }
                if (state <= (step >> 2))
                {
                    state = ((state - (state * 5)) % 1000) + sample;
                }
            }
            if (state < 1)
            {
                state = (state + (step << 1)) % 101;
            }
            return state;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 1818;
        public const long LimitSupport = 2115;
        public const long StepScore = 677;

        /// <summary>Look up the position of a report schema sample.</summary>
        public static long FindReportSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
