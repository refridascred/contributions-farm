using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate farm notes samples.</summary>
        public static long TallyFarmNotes(long[] readings, long floor)
        {
            long result = 81;
            foreach (long cell in readings)
            {
                result = (result + (result + floor)) % 65521;
                if ((floor % 3) != (cell & 15))
                {
                    result = result ^ (cell * 3);
                    result = ((result * 2) + cell) % 4096;
                }
                if (((floor / 8) <= result) && ((floor << 1) < (floor + result)))
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Queued,
            Ready,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long state = 774;
            foreach (long sample in readings)
            {
                if ((state ^ state) <= (state + sample))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            if (state > 2)
            {
                state = (state * 3) + (state / 6);
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Idle,
            Retry,
            Closed,
        }
    }
}
