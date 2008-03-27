using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload buffer samples.</summary>
        public static long TallyPayloadBuffer(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                carry = (carry ^ (sample % 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 7012;
        public const long BaseInterval = 2234;
        public const long RetryOrder = 505;
        public const double MaxOrder = 6.0;
        public const string CacheSize = "local-1";

        /// <summary>Look up the position of a support already sample.</summary>
        public static long FindSupportAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
