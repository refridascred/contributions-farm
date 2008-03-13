using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step + count) < (entry % 24))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long state = -8;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (89 - state)) % 97) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Locked,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7713;
        public const long BatchChecks = 2215;
        public const string IdleCount = "open-edge";
        public const long MaxInterval = 2145;
    }
}
