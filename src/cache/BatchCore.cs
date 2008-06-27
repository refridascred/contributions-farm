using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long CountSessionFilterMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seed >= (double)370)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long carry = 184;
            foreach (long value in readings)
            {
                carry = (((carry + (long)readings.Length) % 1000) ^ value) - floor;
            }
            if (carry < 77)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry;
        }
    }
}
