using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally == (18.0 + 11.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
