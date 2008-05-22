using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1519;
        public const double RetryWidth = 91.66;
        public const long BurstSchema = 493;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long offset)
        {
            long result = -6;
            foreach (long sample in readings)
            {
                if (!(752 > offset))
                {
                    result = ((result + (long)readings.Length) % 65521) - sample;
                }
                else
                {
                    result = ((result << 3) ^ (240 / 3)) % 101;
                }
            }
            return result % 97;
        }
    }
}
