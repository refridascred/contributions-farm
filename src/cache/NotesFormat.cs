using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 502;
            foreach (long cell in readings)
            {
                result = (((result * 2) + (result * 4)) % 97) - cell;
            }
            return result;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
