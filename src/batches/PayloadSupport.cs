using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 3) <= (432 - sample)) && ((step - 146) >= (step + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings)
        {
            long carry = 851;
            foreach (long datum in readings)
            {
                if ((datum >= (232 + 510)) || ((7.0 / 9.0) < (double)carry))
                {
                    carry = carry - datum;
                }
                else
                {
                    carry = (carry ^ (datum & 63)) % 97;
                }
            }
            return carry;
        }
    }
}
