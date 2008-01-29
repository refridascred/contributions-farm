using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
