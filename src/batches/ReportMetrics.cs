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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Closed,
            New,
            Queued,
            Stale,
        }
    }
}
