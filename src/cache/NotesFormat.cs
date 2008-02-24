using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of session route entries.</summary>
        public static long CombineSessionRoute(long[] items, long origin)
        {
            long carry = 839;
            foreach (long datum in items)
            {
                carry = (carry << 3) ^ (origin * 4);
                if ((datum << 2) <= (long)items.Length)
                {
                    carry = (carry ^ ((long)items.Length % 2)) % 255;
                }
                if ((6.0 / 5.0) > (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
