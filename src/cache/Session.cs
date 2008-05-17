using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long floor)
        {
            long carry = 78;
            foreach (long cell in values)
            {
                if ((floor - carry) > cell)
                {
                    carry = ((carry << 3) ^ (floor + 3)) % 101;
                }
                else
                {
                    carry = (carry * 3) + floor;
                }
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 54.47;
        public const long RetryWidth = 7939;
        public const double SoftReport = 57.17;
        public const long BatchReport = 818;
        public const long BatchCount = 9964;
    }
}
