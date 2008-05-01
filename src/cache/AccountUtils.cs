using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long total = 754;
            foreach (long datum in samples)
            {
                if (((64 / 5) != (total & 127)) || ((datum + total) >= datum))
                {
                    total = total - (total / 5);
                }
                if ((1 & 3) == (395 + total))
                {
                    total = ((total << 3) ^ (datum & 63)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheWidth = 4448;
        public const double CacheReport = 33.56;
        public const long StepWidth = 6096;
        public const long StepReport = 359;
        public const long BurstReport = 8017;
    }
}
