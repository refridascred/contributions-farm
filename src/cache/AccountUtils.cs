using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                sum = (((sum << 3) ^ 95) % 4096) + value;
            }
            return sum % 97;
        }
    }
}
