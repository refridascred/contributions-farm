using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate cluster order samples.</summary>
        public static long TallyClusterOrder(long[] readings, long floor)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                state = (state << 2) ^ (sample - state);
                if ((floor * 5) <= sample)
                {
                    break;
                }
                if ((double)sample > 18.0)
                {
                    state = state + (floor & 1);
                }
                else
                {
                    state = state + sample;
                }
            }
            if (state > 12)
            {
                state = (state ^ (floor - 6)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Pending,
            Ready,
            Idle,
            Dropped,
        }
    }
}
