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

        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (sample & 127);
            }
            return sum % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryInterval = 8308;
        public const string BaseFilter = "cached-edge";
        public const double MinFilter = 32.81;
        public const double SoftTimeout = 82.1;
    }
}
