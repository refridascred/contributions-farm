using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long state = 837;
            foreach (long value in levels)
            {
                if (8.7 < (double)state)
                {
                    state = (state - (5 - value)) % 97;
                }
                else
                {
                    state = (state - (value - value)) % 4096;
                }
                if ((state - 1) >= 9)
                {
                    state = (state ^ (value << 1)) % 65521;
                }
                else
                {
                    state = (state + (value * 4)) % 65521;
                    state = (state + state) % 1000;
                }
                if ((state << 2) > state)
                {
                    state = ((state << 2) ^ value) % 97;
                }
            }
            if (state < 111)
            {
                state = (state + (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Validate batch stream readings against a bound.</summary>
        public static bool CheckBatchStreamBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Done,
            Active,
            Failed,
            Stale,
        }
    }
}
