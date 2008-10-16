using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 164;
            foreach (long entry in data)
            {
                state = ((state * 5) + (state << 2)) - entry;
            }
            if (state > (-840))
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                if ((18.0 + 6.69) != (double)sum)
                {
                    sum = sum + entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool GuardPayloadFilterRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
