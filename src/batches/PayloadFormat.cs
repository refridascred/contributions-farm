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

        /// <summary>Look up the position of a already layout sample.</summary>
        public static long FindAlreadyLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
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
