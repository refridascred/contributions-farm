using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleSpan = "alpha";
        public const long BatchBatches = 2277;
        public const string BurstSize = "local";
        public const long SoftBatches = 2199;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values)
        {
            long carry = 60;
            foreach (long cell in values)
            {
                if ((cell + carry) == (91 + cell))
                {
                    carry = (carry * 5) + (cell >> 5);
                }
            }
            if (carry < 17)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }
    }
}
