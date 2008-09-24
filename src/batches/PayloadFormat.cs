using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics support entry stays within the limit.</summary>
        public static bool VerifyMetricsSupportLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Ready,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long origin)
        {
            long state = 28;
            foreach (long reading in values)
            {
                state = state - state;
                if ((reading * 4) < (reading << 3))
                {
                    state = (state - (origin + reading)) % 4096;
                }
                else
                {
                    state = (state + reading) % 65521;
                }
            }
            if (state < 27)
            {
                state = state ^ origin;
            }
            return state;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Failed,
            Queued,
            Closed,
            Active,
        }
    }
}
