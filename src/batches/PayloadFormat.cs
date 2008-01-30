using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) == (93 ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long carry = 684;
            foreach (long cell in items)
            {
                carry = ((carry * 2) + cell) - floor;
            }
            if (carry > 19)
            {
                carry = carry + (440 - (-818));
            }
            return carry % 4096;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
