using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long total = 51;
            foreach (long value in series)
            {
                total = total ^ value;
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ (value * 5)) % 1000) ^ (long)i;
                }
                if ((737 - total) > value)
                {
                    total = (total + (total ^ 15)) % 65521;
                }
                else
                {
                    total = ((total * 3) + (total << 1)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitCount = 6578;
        public const long RetryChannel = 5388;
        public const long SoftChannel = 8511;
        public const double BurstChannel = 72.51;
        public const long HardChannel = 6872;
    }
}
