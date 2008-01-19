using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 85.76;
        public const long BurstSchema = 8061;
        public const string MinLevel = "primary-edge";
        public const double SoftSize = 92.38;
        public const long SoftWidth = 7513;
    }
}
