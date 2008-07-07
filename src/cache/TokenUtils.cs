using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count >= (4.0 / 8.0))
                {
                    count = ((count + 2) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
