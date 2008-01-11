using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                sum = ((sum * 3) + seed) % 65521;
                if ((seed ^ sum) != (entry / 7))
                {
                    sum = (sum * 5) + entry;
                }
            }
            if (sum > (-622))
            {
                sum = ((sum << 3) ^ 196) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings)
        {
            long total = 998;
            foreach (long datum in readings)
            {
                if ((datum << 3) >= total)
                {
                    total = total - 95;
                }
            }
            if (total > 14)
            {
                total = total + (8 + total);
            }
            return total;
        }
    }
}
