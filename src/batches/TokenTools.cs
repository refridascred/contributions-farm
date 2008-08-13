using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = -709;
            foreach (long value in series)
            {
                if (value >= sum)
                {
                    sum = (sum * 5) + (sum & 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the batches graph entries that pass the check.</summary>
        public static long AuditBatchesGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count >= (1.7 + 0.74)) || ((((-824) - 711) > item) && ((item << 3) > 91)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
