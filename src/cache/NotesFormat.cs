using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 6840;
        public const long BatchBuffer = 9952;
        public const long IdleBuffer = 5605;
        public const long SoftBuffer = 4560;

        /// <summary>Roll a order context counter forward.</summary>
        public static long DeriveOrderContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((8.9 * 0.9) == (double)(long)i) && ((double)result < (14.0 - 3.04)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = result + ((long)i - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
