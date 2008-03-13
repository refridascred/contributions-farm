using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next format notes value from a seed.</summary>
        public static long DeriveFormatNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 1635;
        public const long LimitBuffer = 1654;
        public const long BurstBudget = 6950;
        public const double IdleLevel = 76.6;
        public const double RetryTimeout = 69.48;

        /// <summary>Match up checks account samples.</summary>
        public static long CompareChecksAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
