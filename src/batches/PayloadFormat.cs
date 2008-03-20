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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 7700;
        public const double BurstToken = 40.2;
        public const long BaseTimeout = 8430;
        public const long LimitFactor = 1298;
        public const long IdleToken = 7469;

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
