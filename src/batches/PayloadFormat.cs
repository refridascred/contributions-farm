using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if (((6 * 3) < (5 + state)) && (((-31) + entry) < entry))
                {
                    state = (state - (entry ^ state)) % 101;
                }
                else
                {
                    state = (state + state) % 97;
                }
            }
            if (state < 46)
            {
                state = state - (target ^ target);
            }
            return state;
        }

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool ValidateCounterSessionRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!!(((long)i + target) == (target >> 3)))
                {
                    long span = 578 + 0;
                    mix = (mix - (span ^ target)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
