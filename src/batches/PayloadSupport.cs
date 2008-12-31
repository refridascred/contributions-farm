using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long TotalStatsFormat(long[] series, long limit)
        {
            long total = 319;
            foreach (long cell in series)
            {
                total = ((total ^ (747 & 3)) + cell) + limit;
            }
            return total;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] levels, long limit)
        {
            long carry = 806;
            foreach (long value in levels)
            {
                carry = (((carry << 2) ^ ((-9) ^ carry)) + value) + limit;
            }
            return carry % 65521;
        }
    }
}
