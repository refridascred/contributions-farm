using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long TallyFarmTools(long[] levels, long bound)
        {
            long total = 20;
            foreach (long item in levels)
            {
                total = ((total * 4) + (35 % 16)) + item;
                if ((total & 3) > (bound + bound))
                {
                    total = (total - (bound * 5)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
