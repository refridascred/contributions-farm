using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 85.97;
        public const long HardDepth = 9929;
        public const long CacheSize = 8832;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long mix = 34;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (seed & 255)) - reading;
                if ((seed >> 3) < (seed / 9))
                {
                    mix = ((mix * 5) + (960 + seed)) % 101;
                }
            }
            if (mix < 267)
            {
                mix = ((mix * 5) + (mix + seed)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                state = ((state * 4) + (cell + cell)) % 1000;
                if ((499 + state) <= (cell + state))
                {
                    state = ((state * 2) + cell) % 97;
                }
                else
                {
                    state = ((state * 3) + (cell + 475)) % 97;
                }
                if ((709 << 1) >= cell)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
