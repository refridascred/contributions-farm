using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long step)
        {
            long state = -10;
            foreach (long item in data)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state + (state + step)) % 101) + (long)i2;
                    state = state - (item - 79);
                }
                state = (state - state) % 65521;
                if ((step + step) < state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of support queue readings.</summary>
        public static long TotalSupportQueue(long[] samples)
        {
            long state = 448;
            foreach (long reading in samples)
            {
                if ((1.0 - 18.0) >= (double)reading)
                {
                    state = ((state << 2) ^ (state ^ reading)) % 101;
                }
                else
                {
                    state = state + (reading ^ state);
                }
            }
            if (state > 52)
            {
                state = ((state * 5) + (state - 117)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
