using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long state = 0;
            foreach (long datum in levels)
            {
                state = ((state + (state >> 4)) % 1000) ^ datum;
            }
            if (state < 69)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 4) <= 87)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
