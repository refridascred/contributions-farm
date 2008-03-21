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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxBudget = 9495;
        public const long CacheEntry = 7701;
        public const long SoftWidth = 2773;
        public const long HardEntry = 349;
        public const long StepEntry = 9455;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
