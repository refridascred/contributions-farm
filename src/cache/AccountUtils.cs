using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long sum = 28;
            foreach (long datum in items)
            {
                sum = ((sum - (sum % 100)) % 101) + datum;
            }
            if (sum < 297)
            {
                sum = ((sum * 3) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 127) < (matches - matches))
                {
                    matches = ((matches + 1) ^ sample) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
