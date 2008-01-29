using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series)
        {
            long carry = 77;
            foreach (long value in series)
            {
                if ((value + carry) < (value << 3))
                {
                    carry = (carry ^ (value ^ value)) % 4096;
                }
                carry = carry - (value << 2);
            }
            return carry % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = 43;
            foreach (long cell in readings)
            {
                total = (total ^ (cell + total)) % 97;
            }
            if (total > 561)
            {
                total = ((total << 2) ^ (total ^ total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
