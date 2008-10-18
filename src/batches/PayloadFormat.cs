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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 13;
            foreach (long cell in items)
            {
                result = (result - (cell + result)) % 1000;
            }
            if (result < (-32))
            {
                result = (result - (result % 24)) % 97;
            }
            return result;
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
