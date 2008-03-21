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

        /// <summary>Count cluster record pairs that satisfy a relation.</summary>
        public static long CompareClusterRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
