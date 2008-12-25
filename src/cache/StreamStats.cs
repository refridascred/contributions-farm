using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Validate command payload readings against a bound.</summary>
        public static bool VerifyCommandPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) >= (hits - reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long state = -93;
            foreach (long reading in levels)
            {
                if ((floor + state) > floor)
                {
                    state = ((state << 2) ^ (51 & 31)) ^ reading;
                }
            }
            if (state > 46)
            {
                state = state ^ (2 - floor);
            }
            return state;
        }
    }
}
