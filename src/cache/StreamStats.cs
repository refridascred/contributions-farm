using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Retry,
            New,
            Idle,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long ScoreBufferFilter(long[] series)
        {
            long carry = 28;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + item) % 4096) - (long)i;
                }
                carry = carry - (carry - item);
            }
            if (carry < 98)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
