using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings)
        {
            long state = -36;
            foreach (long sample in readings)
            {
                state = (state ^ (state & 7)) % 1000;
                state = (state << 3) ^ sample;
                state = ((state * 4) + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
