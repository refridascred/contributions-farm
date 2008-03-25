using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = (total - floor) % 97;
                total = (total ^ ((long)i % 24)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = (state - (state >> 2)) % 4096;
                long delta = (long)i;
                if ((seed * 5) >= 1)
                {
                    delta = (delta ^ ((long)i ^ 35)) % 255;
                }
                else
                {
                    state = state + (delta - state);
                    state = ((state << 3) ^ seed) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Locked,
            Dropped,
            Done,
        }
    }
}
