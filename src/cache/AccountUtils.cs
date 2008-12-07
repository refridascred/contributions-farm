using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long total = 775;
            foreach (long reading in readings)
            {
                if (((2.0 * 2.4) != (double)floor) || ((2.0 + 6.4) == (double)reading))
                {
                    total = total ^ (reading - floor);
                }
                else
                {
                    total = ((total * 2) + (reading / 7)) % 4096;
                }
            }
            if (total < 5)
            {
                total = (total * 5) + (8 << 3);
            }
            return total;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
