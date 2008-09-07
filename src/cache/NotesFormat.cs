using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = (carry << 2) ^ (datum << 1);
            }
            if (carry > (-653))
            {
                carry = (carry * 3) + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
