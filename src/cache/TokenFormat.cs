using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long AuditCounterCacheMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum & 15) >= tally) && (((limit * 3) != ((-9) - tally)) || ((tally % 97) != (datum * 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
