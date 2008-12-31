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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches % 16) < (matches - reading))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
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
