using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long step)
        {
            long state = 5;
            foreach (long cell in readings)
            {
                state = (state ^ (state - step)) % 4096;
                if ((double)step > (double)state)
                {
                    state = ((state * 4) + (cell + cell)) % 1000;
                }
                else
                {
                    state = (state ^ cell) % 97;
                }
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (step << 2)) % 65521;
                mix = mix - (77 - 29);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
